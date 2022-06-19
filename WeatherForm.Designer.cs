
namespace WeatherForecast
{
    partial class WeatherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.labelCityName = new System.Windows.Forms.Label();
            this.radioButtonToday = new System.Windows.Forms.RadioButton();
            this.radioButton7Days = new System.Windows.Forms.RadioButton();
            this.radioButton14Days = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxForecast = new System.Windows.Forms.TextBox();
            this.buttonSaveAsText = new System.Windows.Forms.Button();
            this.buttonSaveAsJson = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "Вінниця",
            "Горлівка",
            "Дніпро",
            "Донецьк",
            "Житомир",
            "Запоріжжя",
            "Івано-Франківськ",
            "Кам\'янське",
            "Київ",
            "Кривий Ріг",
            "Кропивницький",
            "Луганськ",
            "Луцьк",
            "Львів",
            "Макіївка",
            "Маріуполь",
            "Миколаїв",
            "Одеса",
            "Полтава",
            "Рівне",
            "Севастополь",
            "Сімферополь",
            "Суми",
            "Тернопіль",
            "Харків",
            "Херсон",
            "Хмельницький",
            "Черкаси",
            "Чернівці",
            "Чернігів"});
            this.comboBoxCity.Location = new System.Drawing.Point(9, 30);
            this.comboBoxCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(131, 21);
            this.comboBoxCity.TabIndex = 0;
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.Location = new System.Drawing.Point(7, 14);
            this.labelCityName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(153, 15);
            this.labelCityName.TabIndex = 1;
            this.labelCityName.Text = "Назва населеного пункту";
            // 
            // radioButtonToday
            // 
            this.radioButtonToday.AutoSize = true;
            this.radioButtonToday.Checked = true;
            this.radioButtonToday.Location = new System.Drawing.Point(166, 31);
            this.radioButtonToday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonToday.Name = "radioButtonToday";
            this.radioButtonToday.Size = new System.Drawing.Size(79, 19);
            this.radioButtonToday.TabIndex = 2;
            this.radioButtonToday.TabStop = true;
            this.radioButtonToday.Text = "Сьогодні";
            this.radioButtonToday.UseVisualStyleBackColor = true;
            // 
            // radioButton7Days
            // 
            this.radioButton7Days.AutoSize = true;
            this.radioButton7Days.Location = new System.Drawing.Point(235, 31);
            this.radioButton7Days.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton7Days.Name = "radioButton7Days";
            this.radioButton7Days.Size = new System.Drawing.Size(62, 19);
            this.radioButton7Days.TabIndex = 3;
            this.radioButton7Days.Text = "7 днів";
            this.radioButton7Days.UseVisualStyleBackColor = true;
            // 
            // radioButton14Days
            // 
            this.radioButton14Days.AutoSize = true;
            this.radioButton14Days.Location = new System.Drawing.Point(292, 31);
            this.radioButton14Days.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton14Days.Name = "radioButton14Days";
            this.radioButton14Days.Size = new System.Drawing.Size(69, 19);
            this.radioButton14Days.TabIndex = 4;
            this.radioButton14Days.Text = "14 днів";
            this.radioButton14Days.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(382, 26);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(56, 28);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxForecast
            // 
            this.textBoxForecast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxForecast.Location = new System.Drawing.Point(9, 73);
            this.textBoxForecast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxForecast.Multiline = true;
            this.textBoxForecast.Name = "textBoxForecast";
            this.textBoxForecast.ReadOnly = true;
            this.textBoxForecast.Size = new System.Drawing.Size(638, 284);
            this.textBoxForecast.TabIndex = 6;
            // 
            // buttonSaveAsText
            // 
            this.buttonSaveAsText.Location = new System.Drawing.Point(461, 8);
            this.buttonSaveAsText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveAsText.Name = "buttonSaveAsText";
            this.buttonSaveAsText.Size = new System.Drawing.Size(178, 28);
            this.buttonSaveAsText.TabIndex = 7;
            this.buttonSaveAsText.Text = "Зберегти у текстовий файл";
            this.buttonSaveAsText.UseVisualStyleBackColor = true;
            this.buttonSaveAsText.Click += new System.EventHandler(this.buttonSaveAsText_Click);
            // 
            // buttonSaveAsJson
            // 
            this.buttonSaveAsJson.Location = new System.Drawing.Point(461, 40);
            this.buttonSaveAsJson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveAsJson.Name = "buttonSaveAsJson";
            this.buttonSaveAsJson.Size = new System.Drawing.Size(178, 26);
            this.buttonSaveAsJson.TabIndex = 8;
            this.buttonSaveAsJson.Text = "Зберегти у JSON";
            this.buttonSaveAsJson.UseVisualStyleBackColor = true;
            this.buttonSaveAsJson.Click += new System.EventHandler(this.buttonSaveAsJson_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 366);
            this.Controls.Add(this.buttonSaveAsJson);
            this.Controls.Add(this.buttonSaveAsText);
            this.Controls.Add(this.textBoxForecast);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.radioButton14Days);
            this.Controls.Add(this.radioButton7Days);
            this.Controls.Add(this.radioButtonToday);
            this.Controls.Add(this.labelCityName);
            this.Controls.Add(this.comboBoxCity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WeatherForm";
            this.Text = "Прогноз погоди";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label labelCityName;
        private System.Windows.Forms.RadioButton radioButtonToday;
        private System.Windows.Forms.RadioButton radioButton7Days;
        private System.Windows.Forms.RadioButton radioButton14Days;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxForecast;
        private System.Windows.Forms.Button buttonSaveAsText;
        private System.Windows.Forms.Button buttonSaveAsJson;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

