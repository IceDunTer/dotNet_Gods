namespace Laba4Zadan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Human
        {
            public string name;
            public string age;
            public string height;
        }

        struct Auto
        {
            public string marka;
            public string model;
            public string year;
            public string generation;
        }

        struct admin_building
        {
            public string year;
            public string s;
            public string windows;
            public string rooms;
            public string roz;
        }

        List<string[]> DatBase = new List<string[]>();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string[] HumDat = new string[3];
            HumDat[0] = textBoxHumName.Text;
            HumDat[1] = textBoxHumAge.Text;
            HumDat[2] = textBoxHumHeight.Text;
            DatBase.Add(HumDat);

            string[] AutDat = new string[4];
            AutDat[0] = textBoxAutMarka.Text;
            AutDat[1] = textBoxAutModel.Text;
            AutDat[2] = textBoxAutYear.Text;
            AutDat[3] = textBoxAutGener.Text;
            DatBase.Add(AutDat);

            string[] AdmDat = new string[5];
            AdmDat[0] = textBoxBuiYear.Text;
            AdmDat[1] = textBoxBuiS.Text;
            AdmDat[2] = textBoxBuiWindows.Text;
            AdmDat[3] = textBoxBuiRooms.Text;
            AdmDat[4] = textBoxBuiRoz.Text;
            DatBase.Add(AdmDat);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int index = 0;
            var rec = DatBase[index];

            textBoxHumNameOu.Text = rec[0];
            textBoxHumAgeOu.Text = rec[1];
            textBoxHumHeightOu.Text = rec[2];
            index++;

            rec = DatBase[index];
            textBoxAutMarkaOu.Text = rec[0];
            textBoxAutModelOu.Text = rec[1];
            textBoxAutYearOu.Text = rec[2];
            textBoxAutGenerOu.Text = rec[3];
            index++;

            rec = DatBase[index];
            textBoxBuiYearOu.Text = rec[0];
            textBoxBuiSOu.Text = rec[1];
            textBoxBuiWindowsOu.Text = rec[2];
            textBoxBuiRoomsOu.Text = rec[3];
            textBoxBuiRozOu.Text = rec[4];
        }
    }
}
