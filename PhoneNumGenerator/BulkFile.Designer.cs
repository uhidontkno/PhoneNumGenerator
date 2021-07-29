
namespace PhoneNumGenerator
{
    partial class BulkFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.amountbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 24.25F);
            this.button1.Location = new System.Drawing.Point(171, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 61);
            this.button1.TabIndex = 14;
            this.button1.Text = "Bulk Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // amountbox
            // 
            this.amountbox.Font = new System.Drawing.Font("Montserrat", 12.25F);
            this.amountbox.Location = new System.Drawing.Point(393, 112);
            this.amountbox.MaxLength = 8;
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(111, 27);
            this.amountbox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12.25F);
            this.label3.Location = new System.Drawing.Point(409, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12.25F);
            this.label2.Location = new System.Drawing.Point(167, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Area Code";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Montserrat", 12.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "223",
            "224",
            "225",
            "226",
            "228",
            "229",
            "231",
            "234",
            "236",
            "239",
            "240",
            "242",
            "246",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "256",
            "260",
            "262",
            "264",
            "267",
            "268",
            "269",
            "270",
            "272",
            "276",
            "279",
            "281",
            "284",
            "289",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "309",
            "310",
            "312",
            "313",
            "314",
            "315",
            "316",
            "317",
            "318",
            "319",
            "320",
            "321",
            "323",
            "325",
            "326",
            "330",
            "331",
            "332",
            "334",
            "336",
            "337",
            "339",
            "340",
            "341",
            "343",
            "345",
            "346",
            "347",
            "351",
            "352",
            "360",
            "361",
            "364",
            "365",
            "367",
            "380",
            "385",
            "386",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406",
            "407",
            "408",
            "409",
            "410",
            "412",
            "413",
            "414",
            "415",
            "416",
            "417",
            "418",
            "419",
            "423",
            "424",
            "425",
            "430",
            "431",
            "432",
            "434",
            "435",
            "437",
            "438",
            "440",
            "441",
            "442",
            "443",
            "445",
            "447",
            "448",
            "450",
            "458",
            "463",
            "469",
            "470",
            "473",
            "475",
            "478",
            "479",
            "480",
            "484",
            "501",
            "502",
            "503",
            "504",
            "505",
            "506",
            "507",
            "508",
            "509",
            "510",
            "512",
            "513",
            "514",
            "515",
            "516",
            "517",
            "518",
            "519",
            "520",
            "530",
            "531",
            "534",
            "539",
            "540",
            "541",
            "548",
            "551",
            "559",
            "561",
            "562",
            "563",
            "564",
            "567",
            "570",
            "571",
            "572",
            "573",
            "574",
            "575",
            "579",
            "580",
            "581",
            "582",
            "585",
            "586",
            "587",
            "601",
            "602",
            "603",
            "604",
            "605",
            "606",
            "607",
            "608",
            "609",
            "610",
            "612",
            "613",
            "614",
            "615",
            "616",
            "617",
            "618",
            "619",
            "620",
            "623",
            "626",
            "628",
            "629",
            "630",
            "631",
            "636",
            "639",
            "640",
            "641",
            "646",
            "647",
            "649",
            "650",
            "651",
            "657",
            "658",
            "659",
            "660",
            "661",
            "662",
            "664",
            "667",
            "669",
            "670",
            "671",
            "672",
            "678",
            "680",
            "681",
            "682",
            "684",
            "689",
            "701",
            "702",
            "703",
            "704",
            "705",
            "706",
            "707",
            "708",
            "709",
            "712",
            "713",
            "714",
            "715",
            "716",
            "717",
            "718",
            "719",
            "720",
            "721",
            "724",
            "725",
            "726",
            "727",
            "731",
            "732",
            "734",
            "737",
            "740",
            "743",
            "747",
            "754",
            "757",
            "758",
            "760",
            "762",
            "763",
            "765",
            "767",
            "769",
            "770",
            "772",
            "773",
            "774",
            "775",
            "778",
            "779",
            "780",
            "781",
            "782",
            "784",
            "785",
            "786",
            "787",
            "801",
            "802",
            "803",
            "804",
            "805",
            "806",
            "807",
            "808",
            "809",
            "810",
            "812",
            "813",
            "814",
            "815",
            "816",
            "817",
            "818",
            "819",
            "820",
            "825",
            "828",
            "829",
            "830",
            "831",
            "832",
            "838",
            "839",
            "840",
            "843",
            "845",
            "847",
            "848",
            "849",
            "850",
            "854",
            "856",
            "857",
            "858",
            "859",
            "860",
            "862",
            "863",
            "864",
            "865",
            "867",
            "868",
            "869",
            "870",
            "872",
            "873",
            "876",
            "878",
            "901",
            "902",
            "903",
            "904",
            "905",
            "906",
            "907",
            "908",
            "909",
            "910",
            "912",
            "913",
            "914",
            "915",
            "916",
            "917",
            "918",
            "919",
            "920",
            "925",
            "928",
            "929",
            "930",
            "931",
            "934",
            "936",
            "937",
            "938",
            "939",
            "940",
            "941",
            "945",
            "947",
            "949",
            "951",
            "952",
            "954",
            "956",
            "959",
            "970",
            "971",
            "972",
            "973",
            "978",
            "979",
            "980",
            "984",
            "985",
            "986",
            "989"});
            this.comboBox1.Location = new System.Drawing.Point(121, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 27);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bulk Generate Random Valid Phone Numbers";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "RandomPhones";
            this.saveFileDialog1.Filter = "Text Files|*.txt,*.md|MS Word Files|*.docx,*.doc,*.docm|HTML|*.html,*.htm|All fil" +
    "es|*.*";
            this.saveFileDialog1.InitialDirectory = "C:/Users/%username%/Documents";
            // 
            // BulkFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.amountbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BulkFile";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generate bulk Phone Numbers to file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox amountbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
