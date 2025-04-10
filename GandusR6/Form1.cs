using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text.Json;

namespace GandusR6
{
    public partial class Form1 : Form
    {
        public int xpos = 0;
        public int ypos = 0;
        public int xrc = 0;
        public int yrc = 0;
        public int xcali = 0;
        public int ycali = 0;
        public string gr6 = "Gandus ReC";
        private string currentWeapon;
        private List<CategorySettings> categorySettings;
        private bool isHidden = false;
        private bool GameStatus = false;

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        public static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int HOTKEY_ID_1 = 1;
        private const int HOTKEY_ID_2 = 2;
        private const uint MOD_NONE = 0x0000;
        private const uint VK_P = 0x50; // virtual-key Code for 'P'
        private const uint VK_INSERT = 0x2D; // virtual-key Code for 'Insert'

        [StructLayout(LayoutKind.Sequential)]
        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        public const uint INPUT_MOUSE = 0;
        public const uint MOUSEEVENTF_MOVE = 0x0001;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // delate border
            this.Region = new Region(GetRoundedRectPath(this.ClientRectangle, 20)); // set rounded corners

            // Dodaj obs³ugê zdarzeñ myszy
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing); 
            this.KeyPreview = true;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            recoilTimer.Interval = 15;
            LoadWeaponSettings();
            CreateWeaponButtons(); // create buttons
            panelWpAr.MouseWheel += new MouseEventHandler(panelWpAr_MouseWheel);

            // Zarejestruj globalne skróty klawiszowe
            RegisterHotKey(this.Handle, HOTKEY_ID_1, MOD_NONE, VK_P);
            RegisterHotKey(this.Handle, HOTKEY_ID_2, MOD_NONE, VK_INSERT);
        }

        public class WeaponSettings
        {
            public string name { get; set; }
            public int sety { get; set; }
            public int setx { get; set; }
        }

        public class CategorySettings
        {
            public string name { get; set; }
            public string panel { get; set; }
            public List<WeaponSettings> weapons { get; set; }
        }

        private void LoadWeaponSettings()
        {
            string json = File.ReadAllText("weapons.json");
            var categoriesData = JsonSerializer.Deserialize<Dictionary<string, List<CategorySettings>>>(json);
            categorySettings = categoriesData["categories"];
        }
        private void panelWpAr_MouseWheel(object sender, MouseEventArgs e)
        {
            panelWpAr.AutoScrollPosition = new Point(panelWpAr.AutoScrollPosition.X, panelWpAr.VerticalScroll.Value - e.Delta);
        }

        private void CreateWeaponButtons()
        {
            int buttonHeight = 151;
            int buttonWidth = 282;
            int margin = 10;

            foreach (var category in categorySettings)
            {
                Panel panel = this.Controls.Find(category.panel, true).FirstOrDefault() as Panel;
                if (panel == null) continue;

                int yPos = 10;

                foreach (var weapon in category.weapons)
                {
                    Button btn = new Button();
                    btn.Text = weapon.name;
                    btn.Width = buttonWidth;
                    btn.Height = buttonHeight;
                    btn.Top = yPos;
                    btn.BackColor = Color.FromArgb(64, 68, 75);
                    btn.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.Image = Image.FromFile($"WpImg/R6/R6_{weapon.name}.png");
                    btn.ImageAlign = ContentAlignment.TopCenter;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Left = margin;
                    btn.Click += (sender, e) => RcSet(weapon.name);

                    panel.Controls.Add(btn);
                    yPos += buttonHeight + margin;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("GandusR6 Started");
            Cursor.Clip = this.Bounds;
            this.TopMost = true;
            this.ShowInTaskbar = false;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                if (id == HOTKEY_ID_1)
                {
                    RecoilOn.Checked = !RecoilOn.Checked;
                    Debug.WriteLine($"RecoilOn: {RecoilOn.Checked}");
                }
                else if (id == HOTKEY_ID_2)
                {
                    if (isHidden)
                    {
                        this.Show();
                        isHidden = false;
                    }
                    else
                    {
                        this.Hide();
                        isHidden = true;
                    }
                    Debug.WriteLine($"Window hidden: {isHidden}");
                }
            }
            base.WndProc(ref m);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cursor.Clip = Rectangle.Empty;
            UnregisterHotKey(this.Handle, HOTKEY_ID_1);
            UnregisterHotKey(this.Handle, HOTKEY_ID_2);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = true;
            RecoilPanel.Visible = false;
            SettingsPanel.Visible = false;
            panelRcSet.Visible = false;
        }

        private void RecoilPageBtn_Click(object sender, EventArgs e)
        {
            RecoilPanel.Visible = true;
            HomePanel.Visible = false;
            SettingsPanel.Visible = false;
            panelRcSet.Visible = false;
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
            HomePanel.Visible = false;
            RecoilPanel.Visible = false;
            panelRcSet.Visible = false;
        }
        public bool IsApplicationRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }

        public void CheckApplicationStatus()
        {
            string appName = "RainbowSix";
            bool isRunning = IsApplicationRunning(appName);

            if (isRunning)
            {
                lbGameStatus.ForeColor = Color.Chartreuse;
                lbGameStatus.Text = "R6 is Running";
            }
            else
            {
                lbGameStatus.Text = "R6 is Not Running";
                lbGameStatus.ForeColor = Color.IndianRed;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LiveTime.Text = DateTime.Now.ToString("HH:mm");
            Process[] processes = Process.GetProcessesByName("notepad.exe");
            CheckApplicationStatus();

        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);
            GraphicsPath path = new GraphicsPath();

            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRcSellSmg_Click(object sender, EventArgs e)
        {
            panelRcSell.Visible = false;
            panelRcSmg.Visible = true;
            panelMP.Visible = false;
            panelRcAr.Visible = false;
        }

        private void btnSMGBack_Click(object sender, EventArgs e)
        {
            panelRcSmg.Visible = false;
            panelRcSell.Visible = true;
            panelMP.Visible = false;
        }

        private void btnCali_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
            HomePanel.Visible = false;
            RecoilPanel.Visible = false;
            panelRcSet.Visible = true;
        }

        private void btnBackRcSet_Click(object sender, EventArgs e)
        {
            RecoilPanel.Visible = true;
            HomePanel.Visible = false;
            SettingsPanel.Visible = false;
            panelRcSet.Visible = false;
        }

        private void yBar_Scroll(object sender, EventArgs e)
        {
            yrc = yBar.Value;
            lbPosY.Text = ("Pos Y : -") + yrc.ToString();
        }

        private void xBar_Scroll_1(object sender, EventArgs e)
        {
            xrc = xBar.Value;
            lbPosX.Text = ("Pos X : ") + xrc.ToString();
        }

        private void btnApplyRc_Click(object sender, EventArgs e)
        {
            xcali = xpos;
            ycali = ypos;
            Debug.WriteLine($"btnApplyRc_Click: xcali = {xcali}, ycali = {ycali}");
        }

        private void RecoilOn_CheckedChanged(object sender, EventArgs e)
        {
            if (RecoilOn.Checked)
            {
                recoilTimer.Start();
            }
            else
            {
                recoilTimer.Stop();
            }
        }

        private void recoilTimer_Tick(object sender, EventArgs e)
        {
            if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left &&
                (Control.MouseButtons & MouseButtons.Right) == MouseButtons.Right)
            {
                int deltaX = xrc;
                int deltaY = yrc;

                INPUT[] inputs = new INPUT[]
                {
                    new INPUT
                    {
                        type = INPUT_MOUSE,
                        mi = new MOUSEINPUT
                        {
                            dx = deltaX,
                            dy = deltaY,
                            dwFlags = MOUSEEVENTF_MOVE
                        }
                    }
                };

                uint result = SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

            }
        }

        private void btnMp5_Click(object sender, EventArgs e)
        {
            RcSet("MP5");
        }

        private void RcSet(string wpn)
        {
            var category = categorySettings.FirstOrDefault(c => c.weapons.Any(w => w.name == wpn));
            if (category != null)
            {
                var weapon = category.weapons.FirstOrDefault(w => w.name == wpn);
                if (weapon != null)
                {
                    int sety = weapon.sety;
                    int setx = weapon.setx;
                    currentWeapon = wpn;
                    Debug.WriteLine("Ustawiono " + lbRcWeponSet.Text);
                    GANDUSR6.Text = gr6 + " - " + wpn;
                    lbRcWeponSet.Text = wpn;
                    SettingsPanel.Visible = false;
                    HomePanel.Visible = false;
                    RecoilPanel.Visible = false;
                    panelRcSet.Visible = true;
                    xBar.Value = setx;
                    yBar.Value = sety;
                    lbPosY.Text = ("Pos Y : -") + sety.ToString();
                    lbPosX.Text = ("Pos X : ") + setx.ToString();
                    xrc = setx;
                    yrc = sety;
                }
                else
                {
                    Debug.WriteLine($"Nie znaleziono ustawieñ dla broni: {wpn}");
                }
            }
        }

        private void btnVector45ACP_Click(object sender, EventArgs e)
        {
            RcSet("Vector45");
        }

        private void btnSMG12_Click(object sender, EventArgs e)
        {
            RcSet("SMG-12");
        }

        private void btnRcSellMp_Click(object sender, EventArgs e)
        {
            panelRcSell.Visible = false;
            panelRcSmg.Visible = false;
            panelMP.Visible = true;
            panelRcAr.Visible = false;
        }

        private void btnMPBack_Click(object sender, EventArgs e)
        {
            panelRcSmg.Visible = false;
            panelRcSell.Visible = true;
            panelMP.Visible = false;
            panelRcAr.Visible = false;
        }

        private void btnSMG11_Click(object sender, EventArgs e)
        {
            RcSet("SMG-11");
        }

        private void btnRcSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentWeapon))
            {
                var category = categorySettings.FirstOrDefault(c => c.weapons.Any(w => w.name == currentWeapon));
                if (category != null)
                {
                    var weapon = category.weapons.FirstOrDefault(w => w.name == currentWeapon);
                    if (weapon != null)
                    {
                        weapon.sety = yBar.Value;
                        weapon.setx = xBar.Value;
                        SaveWeaponSettings();
                        Debug.WriteLine($"{currentWeapon} Saved");
                    }
                }
            }
        }

        private void btnRcLoad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentWeapon))
            {
                RcSet(currentWeapon);
                Debug.WriteLine($"Load: {currentWeapon}");
            }
        }

        private void SaveWeaponSettings()
        {
            var categoriesData = new Dictionary<string, List<CategorySettings>> { { "categories", categorySettings } };
            string json = JsonSerializer.Serialize(categoriesData);
            File.WriteAllText("weapons.json", json);
        }

        private void btnBackAr_Click(object sender, EventArgs e)
        {
            panelRcAr.Visible = false;
            panelRcSmg.Visible = false;
            panelRcSell.Visible = true;
            panelMP.Visible = false;
        }

        private void btnRcSellAr_Click(object sender, EventArgs e)
        {
            panelRcAr.Visible = true;
            panelRcSmg.Visible = false;
            panelRcSell.Visible = false;
            panelMP.Visible = false;
        }

        private void lbGameStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
