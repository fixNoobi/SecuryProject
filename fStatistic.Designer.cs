namespace Secury
{
    partial class fStatistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStatistic));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btGeneralInformation = new System.Windows.Forms.ToolStripButton();
            this.tslOrSelectIP = new System.Windows.Forms.ToolStripLabel();
            this.cbAboutIP = new System.Windows.Forms.ToolStripComboBox();
            this.tsbCountry = new System.Windows.Forms.ToolStripLabel();
            this.imgFlags = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tsMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.Size = new System.Drawing.Size(610, 325);
            this.dataGridView1.TabIndex = 6;
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFile,
            this.toolStripSeparator1,
            this.btGeneralInformation,
            this.tslOrSelectIP,
            this.cbAboutIP,
            this.tsbCountry});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMain.Size = new System.Drawing.Size(610, 25);
            this.tsMain.TabIndex = 7;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbFile
            // 
            this.tsbFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.tsbFile.Image = global::Secury.Properties.Resources.monitor;
            this.tsbFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFile.Name = "tsbFile";
            this.tsbFile.Size = new System.Drawing.Size(54, 22);
            this.tsbFile.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btGeneralInformation
            // 
            this.btGeneralInformation.Image = global::Secury.Properties.Resources.wand;
            this.btGeneralInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGeneralInformation.Name = "btGeneralInformation";
            this.btGeneralInformation.Size = new System.Drawing.Size(133, 22);
            this.btGeneralInformation.Text = "General Information";
            this.btGeneralInformation.Click += new System.EventHandler(this.btGeneralInformation_Click);
            // 
            // tslOrSelectIP
            // 
            this.tslOrSelectIP.Name = "tslOrSelectIP";
            this.tslOrSelectIP.Size = new System.Drawing.Size(68, 22);
            this.tslOrSelectIP.Text = "or Select IP:";
            // 
            // cbAboutIP
            // 
            this.cbAboutIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAboutIP.Items.AddRange(new object[] {
            "---Reload---"});
            this.cbAboutIP.Name = "cbAboutIP";
            this.cbAboutIP.Size = new System.Drawing.Size(121, 25);
            this.cbAboutIP.Sorted = true;
            this.cbAboutIP.SelectedIndexChanged += new System.EventHandler(this.cbAboutIP_SelectedIndexChanged);
            // 
            // tsbCountry
            // 
            this.tsbCountry.Name = "tsbCountry";
            this.tsbCountry.Size = new System.Drawing.Size(56, 22);
            this.tsbCountry.Text = "Country: ";
            // 
            // imgFlags
            // 
            this.imgFlags.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFlags.ImageStream")));
            this.imgFlags.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFlags.Images.SetKeyName(0, "Abkhazia.png");
            this.imgFlags.Images.SetKeyName(1, "Afghanistan.png");
            this.imgFlags.Images.SetKeyName(2, "Aland.png");
            this.imgFlags.Images.SetKeyName(3, "Albania.png");
            this.imgFlags.Images.SetKeyName(4, "Algeria.png");
            this.imgFlags.Images.SetKeyName(5, "American-Samoa.png");
            this.imgFlags.Images.SetKeyName(6, "Andorra.png");
            this.imgFlags.Images.SetKeyName(7, "Angola.png");
            this.imgFlags.Images.SetKeyName(8, "Anguilla.png");
            this.imgFlags.Images.SetKeyName(9, "Antarctica.png");
            this.imgFlags.Images.SetKeyName(10, "Antigua-and-Barbuda.png");
            this.imgFlags.Images.SetKeyName(11, "Argentina.png");
            this.imgFlags.Images.SetKeyName(12, "Armenia.png");
            this.imgFlags.Images.SetKeyName(13, "Aruba.png");
            this.imgFlags.Images.SetKeyName(14, "Australia.png");
            this.imgFlags.Images.SetKeyName(15, "Austria.png");
            this.imgFlags.Images.SetKeyName(16, "Azerbaijan.png");
            this.imgFlags.Images.SetKeyName(17, "Bahamas.png");
            this.imgFlags.Images.SetKeyName(18, "Bahrain.png");
            this.imgFlags.Images.SetKeyName(19, "Bangladesh.png");
            this.imgFlags.Images.SetKeyName(20, "Barbados.png");
            this.imgFlags.Images.SetKeyName(21, "Basque-Country.png");
            this.imgFlags.Images.SetKeyName(22, "Belarus.png");
            this.imgFlags.Images.SetKeyName(23, "Belgium.png");
            this.imgFlags.Images.SetKeyName(24, "Belize.png");
            this.imgFlags.Images.SetKeyName(25, "Benin.png");
            this.imgFlags.Images.SetKeyName(26, "Bermuda.png");
            this.imgFlags.Images.SetKeyName(27, "Bhutan.png");
            this.imgFlags.Images.SetKeyName(28, "Bolivia.png");
            this.imgFlags.Images.SetKeyName(29, "Bosnia-and-Herzegovina.png");
            this.imgFlags.Images.SetKeyName(30, "Botswana.png");
            this.imgFlags.Images.SetKeyName(31, "Brazil.png");
            this.imgFlags.Images.SetKeyName(32, "British-Antarctic-Territory.png");
            this.imgFlags.Images.SetKeyName(33, "British-Virgin-Islands.png");
            this.imgFlags.Images.SetKeyName(34, "Brunei.png");
            this.imgFlags.Images.SetKeyName(35, "Bulgaria.png");
            this.imgFlags.Images.SetKeyName(36, "Burkina-Faso.png");
            this.imgFlags.Images.SetKeyName(37, "Burundi.png");
            this.imgFlags.Images.SetKeyName(38, "Cambodia.png");
            this.imgFlags.Images.SetKeyName(39, "Cameroon.png");
            this.imgFlags.Images.SetKeyName(40, "Canada.png");
            this.imgFlags.Images.SetKeyName(41, "Canary-Islands.png");
            this.imgFlags.Images.SetKeyName(42, "Cape-Verde.png");
            this.imgFlags.Images.SetKeyName(43, "Cayman-Islands.png");
            this.imgFlags.Images.SetKeyName(44, "Central-African-Republic.png");
            this.imgFlags.Images.SetKeyName(45, "Chad.png");
            this.imgFlags.Images.SetKeyName(46, "Chile.png");
            this.imgFlags.Images.SetKeyName(47, "China.png");
            this.imgFlags.Images.SetKeyName(48, "Christmas-Island.png");
            this.imgFlags.Images.SetKeyName(49, "Cocos-Keeling-Islands.png");
            this.imgFlags.Images.SetKeyName(50, "Colombia.png");
            this.imgFlags.Images.SetKeyName(51, "Commonwealth.png");
            this.imgFlags.Images.SetKeyName(52, "Comoros.png");
            this.imgFlags.Images.SetKeyName(53, "Cook-Islands.png");
            this.imgFlags.Images.SetKeyName(54, "Costa-Rica.png");
            this.imgFlags.Images.SetKeyName(55, "Cote-dIvoire.png");
            this.imgFlags.Images.SetKeyName(56, "Croatia.png");
            this.imgFlags.Images.SetKeyName(57, "Cuba.png");
            this.imgFlags.Images.SetKeyName(58, "Curacao.png");
            this.imgFlags.Images.SetKeyName(59, "Cyprus.png");
            this.imgFlags.Images.SetKeyName(60, "Czech-Republic.png");
            this.imgFlags.Images.SetKeyName(61, "Democratic-Republic-of-the-Congo.png");
            this.imgFlags.Images.SetKeyName(62, "Denmark.png");
            this.imgFlags.Images.SetKeyName(63, "Djibouti.png");
            this.imgFlags.Images.SetKeyName(64, "Dominica.png");
            this.imgFlags.Images.SetKeyName(65, "Dominican-Republic.png");
            this.imgFlags.Images.SetKeyName(66, "East-Timor.png");
            this.imgFlags.Images.SetKeyName(67, "Ecuador.png");
            this.imgFlags.Images.SetKeyName(68, "Egypt.png");
            this.imgFlags.Images.SetKeyName(69, "El-Salvador.png");
            this.imgFlags.Images.SetKeyName(70, "England.png");
            this.imgFlags.Images.SetKeyName(71, "Equatorial-Guinea.png");
            this.imgFlags.Images.SetKeyName(72, "Eritrea.png");
            this.imgFlags.Images.SetKeyName(73, "Estonia.png");
            this.imgFlags.Images.SetKeyName(74, "Ethiopia.png");
            this.imgFlags.Images.SetKeyName(75, "European-Union.png");
            this.imgFlags.Images.SetKeyName(76, "Falkland-Islands.png");
            this.imgFlags.Images.SetKeyName(77, "Faroes.png");
            this.imgFlags.Images.SetKeyName(78, "Fiji.png");
            this.imgFlags.Images.SetKeyName(79, "Finland.png");
            this.imgFlags.Images.SetKeyName(80, "France.png");
            this.imgFlags.Images.SetKeyName(81, "French-Polynesia.png");
            this.imgFlags.Images.SetKeyName(82, "French-Southern-Territories.png");
            this.imgFlags.Images.SetKeyName(83, "Gabon.png");
            this.imgFlags.Images.SetKeyName(84, "Gambia.png");
            this.imgFlags.Images.SetKeyName(85, "Georgia.png");
            this.imgFlags.Images.SetKeyName(86, "Germany.png");
            this.imgFlags.Images.SetKeyName(87, "Ghana.png");
            this.imgFlags.Images.SetKeyName(88, "Gibraltar.png");
            this.imgFlags.Images.SetKeyName(89, "GoSquared.png");
            this.imgFlags.Images.SetKeyName(90, "Greece.png");
            this.imgFlags.Images.SetKeyName(91, "Greenland.png");
            this.imgFlags.Images.SetKeyName(92, "Grenada.png");
            this.imgFlags.Images.SetKeyName(93, "Guam.png");
            this.imgFlags.Images.SetKeyName(94, "Guatemala.png");
            this.imgFlags.Images.SetKeyName(95, "Guernsey.png");
            this.imgFlags.Images.SetKeyName(96, "Guinea.png");
            this.imgFlags.Images.SetKeyName(97, "Guinea-Bissau.png");
            this.imgFlags.Images.SetKeyName(98, "Guyana.png");
            this.imgFlags.Images.SetKeyName(99, "Haiti.png");
            this.imgFlags.Images.SetKeyName(100, "Honduras.png");
            this.imgFlags.Images.SetKeyName(101, "Hong-Kong.png");
            this.imgFlags.Images.SetKeyName(102, "Hungary.png");
            this.imgFlags.Images.SetKeyName(103, "Iceland.png");
            this.imgFlags.Images.SetKeyName(104, "India.png");
            this.imgFlags.Images.SetKeyName(105, "Indonesia.png");
            this.imgFlags.Images.SetKeyName(106, "Iran.png");
            this.imgFlags.Images.SetKeyName(107, "Iraq.png");
            this.imgFlags.Images.SetKeyName(108, "Ireland.png");
            this.imgFlags.Images.SetKeyName(109, "Isle-of-Man.png");
            this.imgFlags.Images.SetKeyName(110, "Israel.png");
            this.imgFlags.Images.SetKeyName(111, "Italy.png");
            this.imgFlags.Images.SetKeyName(112, "Jamaica.png");
            this.imgFlags.Images.SetKeyName(113, "Japan.png");
            this.imgFlags.Images.SetKeyName(114, "Jersey.png");
            this.imgFlags.Images.SetKeyName(115, "Jordan.png");
            this.imgFlags.Images.SetKeyName(116, "Kazakhstan.png");
            this.imgFlags.Images.SetKeyName(117, "Kenya.png");
            this.imgFlags.Images.SetKeyName(118, "Kiribati.png");
            this.imgFlags.Images.SetKeyName(119, "Kosovo.png");
            this.imgFlags.Images.SetKeyName(120, "Kuwait.png");
            this.imgFlags.Images.SetKeyName(121, "Kyrgyzstan.png");
            this.imgFlags.Images.SetKeyName(122, "Laos.png");
            this.imgFlags.Images.SetKeyName(123, "Latvia.png");
            this.imgFlags.Images.SetKeyName(124, "Lebanon.png");
            this.imgFlags.Images.SetKeyName(125, "Lesotho.png");
            this.imgFlags.Images.SetKeyName(126, "Liberia.png");
            this.imgFlags.Images.SetKeyName(127, "Libya.png");
            this.imgFlags.Images.SetKeyName(128, "Liechtenstein.png");
            this.imgFlags.Images.SetKeyName(129, "Lithuania.png");
            this.imgFlags.Images.SetKeyName(130, "Luxembourg.png");
            this.imgFlags.Images.SetKeyName(131, "Macau.png");
            this.imgFlags.Images.SetKeyName(132, "Macedonia.png");
            this.imgFlags.Images.SetKeyName(133, "Madagascar.png");
            this.imgFlags.Images.SetKeyName(134, "Malawi.png");
            this.imgFlags.Images.SetKeyName(135, "Malaysia.png");
            this.imgFlags.Images.SetKeyName(136, "Maldives.png");
            this.imgFlags.Images.SetKeyName(137, "Mali.png");
            this.imgFlags.Images.SetKeyName(138, "Malta.png");
            this.imgFlags.Images.SetKeyName(139, "Mars.png");
            this.imgFlags.Images.SetKeyName(140, "Marshall-Islands.png");
            this.imgFlags.Images.SetKeyName(141, "Martinique.png");
            this.imgFlags.Images.SetKeyName(142, "Mauritania.png");
            this.imgFlags.Images.SetKeyName(143, "Mauritius.png");
            this.imgFlags.Images.SetKeyName(144, "Mayotte.png");
            this.imgFlags.Images.SetKeyName(145, "Mexico.png");
            this.imgFlags.Images.SetKeyName(146, "Micronesia.png");
            this.imgFlags.Images.SetKeyName(147, "Moldova.png");
            this.imgFlags.Images.SetKeyName(148, "Monaco.png");
            this.imgFlags.Images.SetKeyName(149, "Mongolia.png");
            this.imgFlags.Images.SetKeyName(150, "Montenegro.png");
            this.imgFlags.Images.SetKeyName(151, "Montserrat.png");
            this.imgFlags.Images.SetKeyName(152, "Morocco.png");
            this.imgFlags.Images.SetKeyName(153, "Mozambique.png");
            this.imgFlags.Images.SetKeyName(154, "Myanmar.png");
            this.imgFlags.Images.SetKeyName(155, "Nagorno-Karabakh.png");
            this.imgFlags.Images.SetKeyName(156, "Namibia.png");
            this.imgFlags.Images.SetKeyName(157, "NATO.png");
            this.imgFlags.Images.SetKeyName(158, "Nauru.png");
            this.imgFlags.Images.SetKeyName(159, "Nepal.png");
            this.imgFlags.Images.SetKeyName(160, "Netherlands.png");
            this.imgFlags.Images.SetKeyName(161, "Netherlands-Antilles.png");
            this.imgFlags.Images.SetKeyName(162, "New-Caledonia.png");
            this.imgFlags.Images.SetKeyName(163, "New-Zealand.png");
            this.imgFlags.Images.SetKeyName(164, "Nicaragua.png");
            this.imgFlags.Images.SetKeyName(165, "Niger.png");
            this.imgFlags.Images.SetKeyName(166, "Nigeria.png");
            this.imgFlags.Images.SetKeyName(167, "Niue.png");
            this.imgFlags.Images.SetKeyName(168, "Norfolk-Island.png");
            this.imgFlags.Images.SetKeyName(169, "Northern-Cyprus.png");
            this.imgFlags.Images.SetKeyName(170, "Northern-Mariana-Islands.png");
            this.imgFlags.Images.SetKeyName(171, "North-Korea.png");
            this.imgFlags.Images.SetKeyName(172, "Norway.png");
            this.imgFlags.Images.SetKeyName(173, "Olympics.png");
            this.imgFlags.Images.SetKeyName(174, "Oman.png");
            this.imgFlags.Images.SetKeyName(175, "Pakistan.png");
            this.imgFlags.Images.SetKeyName(176, "Palau.png");
            this.imgFlags.Images.SetKeyName(177, "Palestine.png");
            this.imgFlags.Images.SetKeyName(178, "Panama.png");
            this.imgFlags.Images.SetKeyName(179, "Papua-New-Guinea.png");
            this.imgFlags.Images.SetKeyName(180, "Paraguay.png");
            this.imgFlags.Images.SetKeyName(181, "Peru.png");
            this.imgFlags.Images.SetKeyName(182, "Philippines.png");
            this.imgFlags.Images.SetKeyName(183, "Pitcairn-Islands.png");
            this.imgFlags.Images.SetKeyName(184, "Poland.png");
            this.imgFlags.Images.SetKeyName(185, "Portugal.png");
            this.imgFlags.Images.SetKeyName(186, "Puerto-Rico.png");
            this.imgFlags.Images.SetKeyName(187, "Qatar.png");
            this.imgFlags.Images.SetKeyName(188, "Red-Cross.png");
            this.imgFlags.Images.SetKeyName(189, "Republic-of-the-Congo.png");
            this.imgFlags.Images.SetKeyName(190, "Romania.png");
            this.imgFlags.Images.SetKeyName(191, "Russia.png");
            this.imgFlags.Images.SetKeyName(192, "Rwanda.png");
            this.imgFlags.Images.SetKeyName(193, "Saint-Barthelemy.png");
            this.imgFlags.Images.SetKeyName(194, "Saint-Helena.png");
            this.imgFlags.Images.SetKeyName(195, "Saint-Kitts-and-Nevis.png");
            this.imgFlags.Images.SetKeyName(196, "Saint-Lucia.png");
            this.imgFlags.Images.SetKeyName(197, "Saint-Martin.png");
            this.imgFlags.Images.SetKeyName(198, "Saint-Vincent-and-the-Grenadines.png");
            this.imgFlags.Images.SetKeyName(199, "Samoa.png");
            this.imgFlags.Images.SetKeyName(200, "San-Marino.png");
            this.imgFlags.Images.SetKeyName(201, "Sao-Tome-and-Principe.png");
            this.imgFlags.Images.SetKeyName(202, "Saudi-Arabia.png");
            this.imgFlags.Images.SetKeyName(203, "Scotland.png");
            this.imgFlags.Images.SetKeyName(204, "Senegal.png");
            this.imgFlags.Images.SetKeyName(205, "Serbia.png");
            this.imgFlags.Images.SetKeyName(206, "Seychelles.png");
            this.imgFlags.Images.SetKeyName(207, "Sierra-Leone.png");
            this.imgFlags.Images.SetKeyName(208, "Singapore.png");
            this.imgFlags.Images.SetKeyName(209, "Slovakia.png");
            this.imgFlags.Images.SetKeyName(210, "Slovenia.png");
            this.imgFlags.Images.SetKeyName(211, "Solomon-Islands.png");
            this.imgFlags.Images.SetKeyName(212, "Somalia.png");
            this.imgFlags.Images.SetKeyName(213, "Somaliland.png");
            this.imgFlags.Images.SetKeyName(214, "South-Africa.png");
            this.imgFlags.Images.SetKeyName(215, "South-Georgia-and-the-South-Sandwich-Islands.png");
            this.imgFlags.Images.SetKeyName(216, "South-Korea.png");
            this.imgFlags.Images.SetKeyName(217, "South-Ossetia.png");
            this.imgFlags.Images.SetKeyName(218, "South-Sudan.png");
            this.imgFlags.Images.SetKeyName(219, "Spain.png");
            this.imgFlags.Images.SetKeyName(220, "Sri-Lanka.png");
            this.imgFlags.Images.SetKeyName(221, "Sudan.png");
            this.imgFlags.Images.SetKeyName(222, "Suriname.png");
            this.imgFlags.Images.SetKeyName(223, "Swaziland.png");
            this.imgFlags.Images.SetKeyName(224, "Sweden.png");
            this.imgFlags.Images.SetKeyName(225, "Switzerland.png");
            this.imgFlags.Images.SetKeyName(226, "Syria.png");
            this.imgFlags.Images.SetKeyName(227, "Taiwan.png");
            this.imgFlags.Images.SetKeyName(228, "Tajikistan.png");
            this.imgFlags.Images.SetKeyName(229, "Tanzania.png");
            this.imgFlags.Images.SetKeyName(230, "Thailand.png");
            this.imgFlags.Images.SetKeyName(231, "Togo.png");
            this.imgFlags.Images.SetKeyName(232, "Tokelau.png");
            this.imgFlags.Images.SetKeyName(233, "Tonga.png");
            this.imgFlags.Images.SetKeyName(234, "Trinidad-and-Tobago.png");
            this.imgFlags.Images.SetKeyName(235, "Tunisia.png");
            this.imgFlags.Images.SetKeyName(236, "Turkey.png");
            this.imgFlags.Images.SetKeyName(237, "Turkmenistan.png");
            this.imgFlags.Images.SetKeyName(238, "Turks-and-Caicos-Islands.png");
            this.imgFlags.Images.SetKeyName(239, "Tuvalu.png");
            this.imgFlags.Images.SetKeyName(240, "Uganda.png");
            this.imgFlags.Images.SetKeyName(241, "Ukraine.png");
            this.imgFlags.Images.SetKeyName(242, "United-Arab-Emirates.png");
            this.imgFlags.Images.SetKeyName(243, "United-Kingdom.png");
            this.imgFlags.Images.SetKeyName(244, "United-Nations.png");
            this.imgFlags.Images.SetKeyName(245, "United-States.png");
            this.imgFlags.Images.SetKeyName(246, "invalid-query.png");
            this.imgFlags.Images.SetKeyName(247, "Uruguay.png");
            this.imgFlags.Images.SetKeyName(248, "US-Virgin-Islands.png");
            this.imgFlags.Images.SetKeyName(249, "Uzbekistan.png");
            this.imgFlags.Images.SetKeyName(250, "Vanuatu.png");
            this.imgFlags.Images.SetKeyName(251, "Vatican-City.png");
            this.imgFlags.Images.SetKeyName(252, "Venezuela.png");
            this.imgFlags.Images.SetKeyName(253, "Vietnam.png");
            this.imgFlags.Images.SetKeyName(254, "Wales.png");
            this.imgFlags.Images.SetKeyName(255, "Wallis-And-Futuna.png");
            this.imgFlags.Images.SetKeyName(256, "Western-Sahara.png");
            this.imgFlags.Images.SetKeyName(257, "Yemen.png");
            this.imgFlags.Images.SetKeyName(258, "Zambia.png");
            this.imgFlags.Images.SetKeyName(259, "Zimbabwe.png");
            this.imgFlags.Images.SetKeyName(260, "Republic-of-Korea1.png");
            this.imgFlags.Images.SetKeyName(261, "Republic-of-Korea.png");
            this.imgFlags.Images.SetKeyName(262, "private-range.png");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(610, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(42, 17);
            this.tsslStatus.Text = "Status:";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // fStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 372);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "fStatistic";
            this.ShowInTaskbar = false;
            this.Text = "Statistic";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripDropDownButton tsbFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btGeneralInformation;
        private System.Windows.Forms.ToolStripLabel tslOrSelectIP;
        private System.Windows.Forms.ToolStripComboBox cbAboutIP;
        private System.Windows.Forms.ToolStripLabel tsbCountry;
        private System.Windows.Forms.ImageList imgFlags;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}