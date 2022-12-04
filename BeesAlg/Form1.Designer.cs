namespace BeesAlg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxStopDelta = new System.Windows.Forms.TextBox();
            this.textBoxResearchPointsAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUpperLimitVariables = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLowerLimitVariables = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFunction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVariables = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBeesResearchPointsAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBeesAmountToResearchElitePlaces = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBeesAmountToResearchUsualPlaces = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxElitePlacesAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSearchNeighborhood = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxIterationsAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBoxIterationsAmount = new System.Windows.Forms.CheckBox();
            this.checkBoxStopDelta = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStopDelta
            // 
            this.textBoxStopDelta.Location = new System.Drawing.Point(899, 439);
            this.textBoxStopDelta.Name = "textBoxStopDelta";
            this.textBoxStopDelta.Size = new System.Drawing.Size(115, 31);
            this.textBoxStopDelta.TabIndex = 32;
            this.textBoxStopDelta.Text = "0,001";
            // 
            // textBoxResearchPointsAmount
            // 
            this.textBoxResearchPointsAmount.Location = new System.Drawing.Point(683, 151);
            this.textBoxResearchPointsAmount.Name = "textBoxResearchPointsAmount";
            this.textBoxResearchPointsAmount.Size = new System.Drawing.Size(115, 31);
            this.textBoxResearchPointsAmount.TabIndex = 30;
            this.textBoxResearchPointsAmount.Text = "40";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Количество точек исследования s:";
            // 
            // textBoxUpperLimitVariables
            // 
            this.textBoxUpperLimitVariables.Location = new System.Drawing.Point(670, 21);
            this.textBoxUpperLimitVariables.Name = "textBoxUpperLimitVariables";
            this.textBoxUpperLimitVariables.Size = new System.Drawing.Size(105, 31);
            this.textBoxUpperLimitVariables.TabIndex = 28;
            this.textBoxUpperLimitVariables.Text = "5,11";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(648, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = ";";
            // 
            // textBoxLowerLimitVariables
            // 
            this.textBoxLowerLimitVariables.Location = new System.Drawing.Point(537, 21);
            this.textBoxLowerLimitVariables.Name = "textBoxLowerLimitVariables";
            this.textBoxLowerLimitVariables.Size = new System.Drawing.Size(105, 31);
            this.textBoxLowerLimitVariables.TabIndex = 26;
            this.textBoxLowerLimitVariables.Text = "-5,12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(781, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "[";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(492, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Промежуток генерации случайных значений переменных:";
            // 
            // textBoxFunction
            // 
            this.textBoxFunction.Location = new System.Drawing.Point(128, 104);
            this.textBoxFunction.Name = "textBoxFunction";
            this.textBoxFunction.Size = new System.Drawing.Size(670, 31);
            this.textBoxFunction.TabIndex = 22;
            this.textBoxFunction.Text = "(x - 2)^4 + (x - 2*y)^2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Функция:";
            // 
            // textBoxVariables
            // 
            this.textBoxVariables.Location = new System.Drawing.Point(340, 63);
            this.textBoxVariables.Name = "textBoxVariables";
            this.textBoxVariables.Size = new System.Drawing.Size(458, 31);
            this.textBoxVariables.TabIndex = 20;
            this.textBoxVariables.Text = "x y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Список переменных через пробел:";
            // 
            // textBoxBeesResearchPointsAmount
            // 
            this.textBoxBeesResearchPointsAmount.Location = new System.Drawing.Point(683, 191);
            this.textBoxBeesResearchPointsAmount.Name = "textBoxBeesResearchPointsAmount";
            this.textBoxBeesResearchPointsAmount.Size = new System.Drawing.Size(115, 31);
            this.textBoxBeesResearchPointsAmount.TabIndex = 34;
            this.textBoxBeesResearchPointsAmount.Text = "30";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(437, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "Количество точек исследования пчелами m (m < s):";
            // 
            // textBoxBeesAmountToResearchElitePlaces
            // 
            this.textBoxBeesAmountToResearchElitePlaces.Location = new System.Drawing.Point(683, 265);
            this.textBoxBeesAmountToResearchElitePlaces.Name = "textBoxBeesAmountToResearchElitePlaces";
            this.textBoxBeesAmountToResearchElitePlaces.Size = new System.Drawing.Size(115, 31);
            this.textBoxBeesAmountToResearchElitePlaces.TabIndex = 36;
            this.textBoxBeesAmountToResearchElitePlaces.Text = "30";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(401, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "Число пчел для исследования элитных мест s_e:";
            // 
            // textBoxBeesAmountToResearchUsualPlaces
            // 
            this.textBoxBeesAmountToResearchUsualPlaces.Location = new System.Drawing.Point(683, 302);
            this.textBoxBeesAmountToResearchUsualPlaces.Name = "textBoxBeesAmountToResearchUsualPlaces";
            this.textBoxBeesAmountToResearchUsualPlaces.Size = new System.Drawing.Size(115, 31);
            this.textBoxBeesAmountToResearchUsualPlaces.TabIndex = 38;
            this.textBoxBeesAmountToResearchUsualPlaces.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(413, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "Число пчел для исследования обычных мест s_p:";
            // 
            // textBoxElitePlacesAmount
            // 
            this.textBoxElitePlacesAmount.Location = new System.Drawing.Point(683, 228);
            this.textBoxElitePlacesAmount.Name = "textBoxElitePlacesAmount";
            this.textBoxElitePlacesAmount.Size = new System.Drawing.Size(115, 31);
            this.textBoxElitePlacesAmount.TabIndex = 40;
            this.textBoxElitePlacesAmount.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(326, 25);
            this.label12.TabIndex = 39;
            this.label12.Text = "Количество элитных мест e (e < m / 2):";
            // 
            // textBoxSearchNeighborhood
            // 
            this.textBoxSearchNeighborhood.Location = new System.Drawing.Point(683, 339);
            this.textBoxSearchNeighborhood.Name = "textBoxSearchNeighborhood";
            this.textBoxSearchNeighborhood.Size = new System.Drawing.Size(115, 31);
            this.textBoxSearchNeighborhood.TabIndex = 42;
            this.textBoxSearchNeighborhood.Text = "1,5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 25);
            this.label13.TabIndex = 41;
            this.label13.Text = "Окрестность поиска δ:";
            // 
            // textBoxIterationsAmount
            // 
            this.textBoxIterationsAmount.Location = new System.Drawing.Point(237, 439);
            this.textBoxIterationsAmount.Name = "textBoxIterationsAmount";
            this.textBoxIterationsAmount.Size = new System.Drawing.Size(115, 31);
            this.textBoxIterationsAmount.TabIndex = 44;
            this.textBoxIterationsAmount.Text = "20";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(821, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 25);
            this.label15.TabIndex = 45;
            this.label15.Text = "(m - e = p, e < p)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(565, 473);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(328, 25);
            this.label16.TabIndex = 46;
            this.label16.Text = "(полученными на соседних итерациях)";
            // 
            // checkBoxIterationsAmount
            // 
            this.checkBoxIterationsAmount.AutoSize = true;
            this.checkBoxIterationsAmount.Checked = true;
            this.checkBoxIterationsAmount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIterationsAmount.Location = new System.Drawing.Point(12, 441);
            this.checkBoxIterationsAmount.Name = "checkBoxIterationsAmount";
            this.checkBoxIterationsAmount.Size = new System.Drawing.Size(219, 29);
            this.checkBoxIterationsAmount.TabIndex = 47;
            this.checkBoxIterationsAmount.Text = "Количество итераций:";
            this.checkBoxIterationsAmount.UseVisualStyleBackColor = true;
            // 
            // checkBoxStopDelta
            // 
            this.checkBoxStopDelta.AutoSize = true;
            this.checkBoxStopDelta.Location = new System.Drawing.Point(537, 441);
            this.checkBoxStopDelta.Name = "checkBoxStopDelta";
            this.checkBoxStopDelta.Size = new System.Drawing.Size(356, 29);
            this.checkBoxStopDelta.TabIndex = 48;
            this.checkBoxStopDelta.Text = "Разность между лучшими значениями:";
            this.checkBoxStopDelta.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Критерии остановки";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(84, 602);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 25);
            this.label14.TabIndex = 50;
            this.label14.Text = "Найденный минимум:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.AcceptsReturn = true;
            this.textBoxOutput.AcceptsTab = true;
            this.textBoxOutput.Location = new System.Drawing.Point(298, 599);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(412, 136);
            this.textBoxOutput.TabIndex = 51;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(422, 531);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(164, 48);
            this.buttonStart.TabIndex = 52;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 747);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxStopDelta);
            this.Controls.Add(this.checkBoxIterationsAmount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxIterationsAmount);
            this.Controls.Add(this.textBoxSearchNeighborhood);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxElitePlacesAmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxBeesAmountToResearchUsualPlaces);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxBeesAmountToResearchElitePlaces);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxBeesResearchPointsAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxStopDelta);
            this.Controls.Add(this.textBoxResearchPointsAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUpperLimitVariables);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxLowerLimitVariables);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFunction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVariables);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Пчелиный алгоритм";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxStopDelta;
        private TextBox textBoxResearchPointsAmount;
        private Label label3;
        private TextBox textBoxUpperLimitVariables;
        private Label label7;
        private TextBox textBoxLowerLimitVariables;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBoxFunction;
        private Label label2;
        private TextBox textBoxVariables;
        private Label label1;
        private TextBox textBoxBeesResearchPointsAmount;
        private Label label9;
        private TextBox textBoxBeesAmountToResearchElitePlaces;
        private Label label10;
        private TextBox textBoxBeesAmountToResearchUsualPlaces;
        private Label label11;
        private TextBox textBoxElitePlacesAmount;
        private Label label12;
        private TextBox textBoxSearchNeighborhood;
        private Label label13;
        private TextBox textBoxIterationsAmount;
        private Label label15;
        private Label label16;
        private CheckBox checkBoxIterationsAmount;
        private CheckBox checkBoxStopDelta;
        private Label label8;
        private Label label14;
        private TextBox textBoxOutput;
        private Button buttonStart;
    }
}