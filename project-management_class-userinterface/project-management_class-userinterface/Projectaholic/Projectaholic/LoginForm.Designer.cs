
namespace Projectaholic
{
    partial class LoginForm
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
            this.LogUserInputTextBox = new System.Windows.Forms.TextBox();
            this.LogPassInputTextBox = new System.Windows.Forms.TextBox();
            this.LogInMainPanel = new System.Windows.Forms.Panel();
            this.ForgetCredentialsPanel = new System.Windows.Forms.Panel();
            this.RecoveryPartThreePanel = new System.Windows.Forms.Panel();
            this.RecoveryPart3ConfirmErrorLabel = new System.Windows.Forms.Label();
            this.RecoveryPart3ConfirmTextBox = new System.Windows.Forms.TextBox();
            this.RecoveryPart3ConfirmLabel = new System.Windows.Forms.Label();
            this.RecoveryPart3PassErrorLabel = new System.Windows.Forms.Label();
            this.RecoveryPart3NewTextBox = new System.Windows.Forms.TextBox();
            this.RecoveryPart3NewPassLabel = new System.Windows.Forms.Label();
            this.RecoveryPart3Label = new System.Windows.Forms.Label();
            this.RecoveryPartTwoPanel = new System.Windows.Forms.Panel();
            this.RecoveryPart2AnswerTextBox = new System.Windows.Forms.TextBox();
            this.SecurityQuestionPart2Label = new System.Windows.Forms.Label();
            this.RecoveryPart2Label = new System.Windows.Forms.Label();
            this.RecoveryBackButton = new System.Windows.Forms.Button();
            this.RecoveryNextButton = new System.Windows.Forms.Button();
            this.RecoverPartOnePanel = new System.Windows.Forms.Panel();
            this.RecoveryPart1UserErrorLabel = new System.Windows.Forms.Label();
            this.RecoveryPart1UserTextBox = new System.Windows.Forms.TextBox();
            this.RecoveryPart1Label = new System.Windows.Forms.Label();
            this.RecoveryLabel = new System.Windows.Forms.Label();
            this.NewAccountButton = new System.Windows.Forms.Button();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.SecurityAnswerErrorLabel = new System.Windows.Forms.Label();
            this.SecurityQuestionErrorLabel = new System.Windows.Forms.Label();
            this.ConfirmErrorLabel = new System.Windows.Forms.Label();
            this.PassInputErrorLabel = new System.Windows.Forms.Label();
            this.UserInputErrorLabel = new System.Windows.Forms.Label();
            this.NewSecurityQuestionComboBox = new System.Windows.Forms.ComboBox();
            this.NewSecurityAnswerInputTextBox = new System.Windows.Forms.TextBox();
            this.NewConfirmInputTextBox = new System.Windows.Forms.TextBox();
            this.NewPassInputTextBox = new System.Windows.Forms.TextBox();
            this.NewUserInputTextBox = new System.Windows.Forms.TextBox();
            this.RegisterAccountLabel = new System.Windows.Forms.Label();
            this.RegisterGoBackButton = new System.Windows.Forms.Button();
            this.RegisterAccountButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ForgetButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.LogInTitle = new System.Windows.Forms.Label();
            this.LogPassLabel = new System.Windows.Forms.Label();
            this.LogUserLabel = new System.Windows.Forms.Label();
            this.LogInMainPanel.SuspendLayout();
            this.ForgetCredentialsPanel.SuspendLayout();
            this.RecoveryPartThreePanel.SuspendLayout();
            this.RecoveryPartTwoPanel.SuspendLayout();
            this.RecoverPartOnePanel.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogUserInputTextBox
            // 
            this.LogUserInputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogUserInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogUserInputTextBox.Location = new System.Drawing.Point(244, 189);
            this.LogUserInputTextBox.Name = "LogUserInputTextBox";
            this.LogUserInputTextBox.Size = new System.Drawing.Size(569, 38);
            this.LogUserInputTextBox.TabIndex = 0;
            // 
            // LogPassInputTextBox
            // 
            this.LogPassInputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogPassInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogPassInputTextBox.Location = new System.Drawing.Point(244, 277);
            this.LogPassInputTextBox.Name = "LogPassInputTextBox";
            this.LogPassInputTextBox.PasswordChar = '*';
            this.LogPassInputTextBox.Size = new System.Drawing.Size(569, 38);
            this.LogPassInputTextBox.TabIndex = 1;
            // 
            // LogInMainPanel
            // 
            this.LogInMainPanel.Controls.Add(this.ForgetCredentialsPanel);
            this.LogInMainPanel.Controls.Add(this.NewAccountButton);
            this.LogInMainPanel.Controls.Add(this.RegisterPanel);
            this.LogInMainPanel.Controls.Add(this.ForgetButton);
            this.LogInMainPanel.Controls.Add(this.LogInButton);
            this.LogInMainPanel.Controls.Add(this.LogInTitle);
            this.LogInMainPanel.Controls.Add(this.LogPassLabel);
            this.LogInMainPanel.Controls.Add(this.LogUserLabel);
            this.LogInMainPanel.Controls.Add(this.LogUserInputTextBox);
            this.LogInMainPanel.Controls.Add(this.LogPassInputTextBox);
            this.LogInMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogInMainPanel.Location = new System.Drawing.Point(0, 0);
            this.LogInMainPanel.Name = "LogInMainPanel";
            this.LogInMainPanel.Size = new System.Drawing.Size(1000, 550);
            this.LogInMainPanel.TabIndex = 2;
            // 
            // ForgetCredentialsPanel
            // 
            this.ForgetCredentialsPanel.Controls.Add(this.RecoveryPartThreePanel);
            this.ForgetCredentialsPanel.Controls.Add(this.RecoveryPartTwoPanel);
            this.ForgetCredentialsPanel.Controls.Add(this.RecoveryBackButton);
            this.ForgetCredentialsPanel.Controls.Add(this.RecoveryNextButton);
            this.ForgetCredentialsPanel.Controls.Add(this.RecoverPartOnePanel);
            this.ForgetCredentialsPanel.Controls.Add(this.RecoveryLabel);
            this.ForgetCredentialsPanel.Location = new System.Drawing.Point(948, 59);
            this.ForgetCredentialsPanel.Name = "ForgetCredentialsPanel";
            this.ForgetCredentialsPanel.Size = new System.Drawing.Size(27, 17);
            this.ForgetCredentialsPanel.TabIndex = 8;
            // 
            // RecoveryPartThreePanel
            // 
            this.RecoveryPartThreePanel.Controls.Add(this.RecoveryPart3ConfirmErrorLabel);
            this.RecoveryPartThreePanel.Controls.Add(this.RecoveryPart3ConfirmTextBox);
            this.RecoveryPartThreePanel.Controls.Add(this.RecoveryPart3ConfirmLabel);
            this.RecoveryPartThreePanel.Controls.Add(this.RecoveryPart3PassErrorLabel);
            this.RecoveryPartThreePanel.Controls.Add(this.RecoveryPart3NewTextBox);
            this.RecoveryPartThreePanel.Controls.Add(this.RecoveryPart3NewPassLabel);
            this.RecoveryPartThreePanel.Controls.Add(this.RecoveryPart3Label);
            this.RecoveryPartThreePanel.Location = new System.Drawing.Point(140, 108);
            this.RecoveryPartThreePanel.Name = "RecoveryPartThreePanel";
            this.RecoveryPartThreePanel.Size = new System.Drawing.Size(860, 340);
            this.RecoveryPartThreePanel.TabIndex = 14;
            // 
            // RecoveryPart3ConfirmErrorLabel
            // 
            this.RecoveryPart3ConfirmErrorLabel.AutoSize = true;
            this.RecoveryPart3ConfirmErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryPart3ConfirmErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.RecoveryPart3ConfirmErrorLabel.Location = new System.Drawing.Point(633, 130);
            this.RecoveryPart3ConfirmErrorLabel.Name = "RecoveryPart3ConfirmErrorLabel";
            this.RecoveryPart3ConfirmErrorLabel.Size = new System.Drawing.Size(104, 17);
            this.RecoveryPart3ConfirmErrorLabel.TabIndex = 21;
            this.RecoveryPart3ConfirmErrorLabel.Text = "Field Required.";
            // 
            // RecoveryPart3ConfirmTextBox
            // 
            this.RecoveryPart3ConfirmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryPart3ConfirmTextBox.Location = new System.Drawing.Point(151, 126);
            this.RecoveryPart3ConfirmTextBox.Name = "RecoveryPart3ConfirmTextBox";
            this.RecoveryPart3ConfirmTextBox.PasswordChar = '*';
            this.RecoveryPart3ConfirmTextBox.Size = new System.Drawing.Size(469, 23);
            this.RecoveryPart3ConfirmTextBox.TabIndex = 20;
            // 
            // RecoveryPart3ConfirmLabel
            // 
            this.RecoveryPart3ConfirmLabel.AutoSize = true;
            this.RecoveryPart3ConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryPart3ConfirmLabel.Location = new System.Drawing.Point(13, 126);
            this.RecoveryPart3ConfirmLabel.Name = "RecoveryPart3ConfirmLabel";
            this.RecoveryPart3ConfirmLabel.Size = new System.Drawing.Size(133, 20);
            this.RecoveryPart3ConfirmLabel.TabIndex = 19;
            this.RecoveryPart3ConfirmLabel.Text = "ConfirmPassword";
            // 
            // RecoveryPart3PassErrorLabel
            // 
            this.RecoveryPart3PassErrorLabel.AutoSize = true;
            this.RecoveryPart3PassErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryPart3PassErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.RecoveryPart3PassErrorLabel.Location = new System.Drawing.Point(634, 87);
            this.RecoveryPart3PassErrorLabel.Name = "RecoveryPart3PassErrorLabel";
            this.RecoveryPart3PassErrorLabel.Size = new System.Drawing.Size(104, 17);
            this.RecoveryPart3PassErrorLabel.TabIndex = 18;
            this.RecoveryPart3PassErrorLabel.Text = "Field Required.";
            this.RecoveryPart3PassErrorLabel.Click += new System.EventHandler(this.label19_Click);
            // 
            // RecoveryPart3NewTextBox
            // 
            this.RecoveryPart3NewTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryPart3NewTextBox.Location = new System.Drawing.Point(152, 83);
            this.RecoveryPart3NewTextBox.Name = "RecoveryPart3NewTextBox";
            this.RecoveryPart3NewTextBox.PasswordChar = '*';
            this.RecoveryPart3NewTextBox.Size = new System.Drawing.Size(469, 23);
            this.RecoveryPart3NewTextBox.TabIndex = 17;
            this.RecoveryPart3NewTextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // RecoveryPart3NewPassLabel
            // 
            this.RecoveryPart3NewPassLabel.AutoSize = true;
            this.RecoveryPart3NewPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryPart3NewPassLabel.Location = new System.Drawing.Point(33, 83);
            this.RecoveryPart3NewPassLabel.Name = "RecoveryPart3NewPassLabel";
            this.RecoveryPart3NewPassLabel.Size = new System.Drawing.Size(113, 20);
            this.RecoveryPart3NewPassLabel.TabIndex = 16;
            this.RecoveryPart3NewPassLabel.Text = "New Password";
            this.RecoveryPart3NewPassLabel.Click += new System.EventHandler(this.label20_Click);
            // 
            // RecoveryPart3Label
            // 
            this.RecoveryPart3Label.AutoSize = true;
            this.RecoveryPart3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryPart3Label.Location = new System.Drawing.Point(24, 17);
            this.RecoveryPart3Label.Name = "RecoveryPart3Label";
            this.RecoveryPart3Label.Size = new System.Drawing.Size(241, 17);
            this.RecoveryPart3Label.TabIndex = 15;
            this.RecoveryPart3Label.Text = "Please reset your account password:";
            // 
            // RecoveryPartTwoPanel
            // 
            this.RecoveryPartTwoPanel.Controls.Add(this.RecoveryPart2AnswerTextBox);
            this.RecoveryPartTwoPanel.Controls.Add(this.SecurityQuestionPart2Label);
            this.RecoveryPartTwoPanel.Controls.Add(this.RecoveryPart2Label);
            this.RecoveryPartTwoPanel.Location = new System.Drawing.Point(140, 108);
            this.RecoveryPartTwoPanel.Name = "RecoveryPartTwoPanel";
            this.RecoveryPartTwoPanel.Size = new System.Drawing.Size(860, 340);
            this.RecoveryPartTwoPanel.TabIndex = 13;
            // 
            // RecoveryPart2AnswerTextBox
            // 
            this.RecoveryPart2AnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryPart2AnswerTextBox.Location = new System.Drawing.Point(99, 169);
            this.RecoveryPart2AnswerTextBox.Multiline = true;
            this.RecoveryPart2AnswerTextBox.Name = "RecoveryPart2AnswerTextBox";
            this.RecoveryPart2AnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecoveryPart2AnswerTextBox.Size = new System.Drawing.Size(525, 55);
            this.RecoveryPart2AnswerTextBox.TabIndex = 2;
            // 
            // SecurityQuestionPart2Label
            // 
            this.SecurityQuestionPart2Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecurityQuestionPart2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityQuestionPart2Label.Location = new System.Drawing.Point(19, 98);
            this.SecurityQuestionPart2Label.Name = "SecurityQuestionPart2Label";
            this.SecurityQuestionPart2Label.Size = new System.Drawing.Size(717, 63);
            this.SecurityQuestionPart2Label.TabIndex = 1;
            this.SecurityQuestionPart2Label.Text = "[SECURITY QUESTION]";
            this.SecurityQuestionPart2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecoveryPart2Label
            // 
            this.RecoveryPart2Label.AutoSize = true;
            this.RecoveryPart2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryPart2Label.Location = new System.Drawing.Point(24, 17);
            this.RecoveryPart2Label.Name = "RecoveryPart2Label";
            this.RecoveryPart2Label.Size = new System.Drawing.Size(297, 17);
            this.RecoveryPart2Label.TabIndex = 0;
            this.RecoveryPart2Label.Text = "Please answer the following security question:";
            // 
            // RecoveryBackButton
            // 
            this.RecoveryBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryBackButton.Location = new System.Drawing.Point(413, 512);
            this.RecoveryBackButton.Name = "RecoveryBackButton";
            this.RecoveryBackButton.Size = new System.Drawing.Size(189, 29);
            this.RecoveryBackButton.TabIndex = 12;
            this.RecoveryBackButton.Text = "Go back";
            this.RecoveryBackButton.UseVisualStyleBackColor = true;
            // 
            // RecoveryNextButton
            // 
            this.RecoveryNextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryNextButton.Location = new System.Drawing.Point(397, 461);
            this.RecoveryNextButton.Name = "RecoveryNextButton";
            this.RecoveryNextButton.Size = new System.Drawing.Size(223, 45);
            this.RecoveryNextButton.TabIndex = 11;
            this.RecoveryNextButton.Text = "Next";
            this.RecoveryNextButton.UseVisualStyleBackColor = true;
            // 
            // RecoverPartOnePanel
            // 
            this.RecoverPartOnePanel.Controls.Add(this.RecoveryPart1UserErrorLabel);
            this.RecoverPartOnePanel.Controls.Add(this.RecoveryPart1UserTextBox);
            this.RecoverPartOnePanel.Controls.Add(this.RecoveryPart1Label);
            this.RecoverPartOnePanel.Location = new System.Drawing.Point(140, 108);
            this.RecoverPartOnePanel.Name = "RecoverPartOnePanel";
            this.RecoverPartOnePanel.Size = new System.Drawing.Size(857, 100);
            this.RecoverPartOnePanel.TabIndex = 10;
            // 
            // RecoveryPart1UserErrorLabel
            // 
            this.RecoveryPart1UserErrorLabel.AutoSize = true;
            this.RecoveryPart1UserErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryPart1UserErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.RecoveryPart1UserErrorLabel.Location = new System.Drawing.Point(604, 43);
            this.RecoveryPart1UserErrorLabel.Name = "RecoveryPart1UserErrorLabel";
            this.RecoveryPart1UserErrorLabel.Size = new System.Drawing.Size(104, 17);
            this.RecoveryPart1UserErrorLabel.TabIndex = 11;
            this.RecoveryPart1UserErrorLabel.Text = "Field Required.";
            // 
            // RecoveryPart1UserTextBox
            // 
            this.RecoveryPart1UserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryPart1UserTextBox.Location = new System.Drawing.Point(122, 39);
            this.RecoveryPart1UserTextBox.Name = "RecoveryPart1UserTextBox";
            this.RecoveryPart1UserTextBox.Size = new System.Drawing.Size(469, 23);
            this.RecoveryPart1UserTextBox.TabIndex = 10;
            // 
            // RecoveryPart1Label
            // 
            this.RecoveryPart1Label.AutoSize = true;
            this.RecoveryPart1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryPart1Label.Location = new System.Drawing.Point(23, 40);
            this.RecoveryPart1Label.Name = "RecoveryPart1Label";
            this.RecoveryPart1Label.Size = new System.Drawing.Size(83, 20);
            this.RecoveryPart1Label.TabIndex = 9;
            this.RecoveryPart1Label.Text = "Username";
            // 
            // RecoveryLabel
            // 
            this.RecoveryLabel.AutoSize = true;
            this.RecoveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryLabel.Location = new System.Drawing.Point(41, 40);
            this.RecoveryLabel.Name = "RecoveryLabel";
            this.RecoveryLabel.Size = new System.Drawing.Size(222, 31);
            this.RecoveryLabel.TabIndex = 9;
            this.RecoveryLabel.Text = "Recover Account";
            this.RecoveryLabel.Click += new System.EventHandler(this.label14_Click);
            // 
            // NewAccountButton
            // 
            this.NewAccountButton.Location = new System.Drawing.Point(498, 450);
            this.NewAccountButton.Name = "NewAccountButton";
            this.NewAccountButton.Size = new System.Drawing.Size(162, 45);
            this.NewAccountButton.TabIndex = 6;
            this.NewAccountButton.Text = "Register new account";
            this.NewAccountButton.UseVisualStyleBackColor = true;
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Controls.Add(this.SecurityAnswerErrorLabel);
            this.RegisterPanel.Controls.Add(this.SecurityQuestionErrorLabel);
            this.RegisterPanel.Controls.Add(this.ConfirmErrorLabel);
            this.RegisterPanel.Controls.Add(this.PassInputErrorLabel);
            this.RegisterPanel.Controls.Add(this.UserInputErrorLabel);
            this.RegisterPanel.Controls.Add(this.NewSecurityQuestionComboBox);
            this.RegisterPanel.Controls.Add(this.NewSecurityAnswerInputTextBox);
            this.RegisterPanel.Controls.Add(this.NewConfirmInputTextBox);
            this.RegisterPanel.Controls.Add(this.NewPassInputTextBox);
            this.RegisterPanel.Controls.Add(this.NewUserInputTextBox);
            this.RegisterPanel.Controls.Add(this.RegisterAccountLabel);
            this.RegisterPanel.Controls.Add(this.RegisterGoBackButton);
            this.RegisterPanel.Controls.Add(this.RegisterAccountButton);
            this.RegisterPanel.Controls.Add(this.label7);
            this.RegisterPanel.Controls.Add(this.label6);
            this.RegisterPanel.Controls.Add(this.label5);
            this.RegisterPanel.Controls.Add(this.label4);
            this.RegisterPanel.Controls.Add(this.label3);
            this.RegisterPanel.Location = new System.Drawing.Point(948, 12);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(27, 34);
            this.RegisterPanel.TabIndex = 7;
            // 
            // SecurityAnswerErrorLabel
            // 
            this.SecurityAnswerErrorLabel.AutoSize = true;
            this.SecurityAnswerErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityAnswerErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.SecurityAnswerErrorLabel.Location = new System.Drawing.Point(759, 342);
            this.SecurityAnswerErrorLabel.Name = "SecurityAnswerErrorLabel";
            this.SecurityAnswerErrorLabel.Size = new System.Drawing.Size(99, 17);
            this.SecurityAnswerErrorLabel.TabIndex = 19;
            this.SecurityAnswerErrorLabel.Text = "Field required.";
            // 
            // SecurityQuestionErrorLabel
            // 
            this.SecurityQuestionErrorLabel.AutoSize = true;
            this.SecurityQuestionErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityQuestionErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.SecurityQuestionErrorLabel.Location = new System.Drawing.Point(759, 285);
            this.SecurityQuestionErrorLabel.Name = "SecurityQuestionErrorLabel";
            this.SecurityQuestionErrorLabel.Size = new System.Drawing.Size(99, 17);
            this.SecurityQuestionErrorLabel.TabIndex = 18;
            this.SecurityQuestionErrorLabel.Text = "Field required.";
            // 
            // ConfirmErrorLabel
            // 
            this.ConfirmErrorLabel.AutoSize = true;
            this.ConfirmErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ConfirmErrorLabel.Location = new System.Drawing.Point(759, 217);
            this.ConfirmErrorLabel.Name = "ConfirmErrorLabel";
            this.ConfirmErrorLabel.Size = new System.Drawing.Size(99, 17);
            this.ConfirmErrorLabel.TabIndex = 17;
            this.ConfirmErrorLabel.Text = "Field required.";
            // 
            // PassInputErrorLabel
            // 
            this.PassInputErrorLabel.AutoSize = true;
            this.PassInputErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassInputErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.PassInputErrorLabel.Location = new System.Drawing.Point(759, 163);
            this.PassInputErrorLabel.Name = "PassInputErrorLabel";
            this.PassInputErrorLabel.Size = new System.Drawing.Size(99, 17);
            this.PassInputErrorLabel.TabIndex = 16;
            this.PassInputErrorLabel.Text = "Field required.";
            // 
            // UserInputErrorLabel
            // 
            this.UserInputErrorLabel.AutoSize = true;
            this.UserInputErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.UserInputErrorLabel.Location = new System.Drawing.Point(759, 112);
            this.UserInputErrorLabel.Name = "UserInputErrorLabel";
            this.UserInputErrorLabel.Size = new System.Drawing.Size(99, 17);
            this.UserInputErrorLabel.TabIndex = 15;
            this.UserInputErrorLabel.Text = "Field required.";
            // 
            // NewSecurityQuestionComboBox
            // 
            this.NewSecurityQuestionComboBox.FormattingEnabled = true;
            this.NewSecurityQuestionComboBox.Items.AddRange(new object[] {
            "What is your favorite album?",
            "What is your favorite pet\'s name?",
            "Where did your parents get married?",
            "What was your elementary school\'s name?",
            "What was your middle school\'s name?",
            "What was your high school\'s name?",
            "What is your favorite hobby?",
            "What city were you born in?"});
            this.NewSecurityQuestionComboBox.Location = new System.Drawing.Point(267, 284);
            this.NewSecurityQuestionComboBox.Name = "NewSecurityQuestionComboBox";
            this.NewSecurityQuestionComboBox.Size = new System.Drawing.Size(469, 21);
            this.NewSecurityQuestionComboBox.TabIndex = 14;
            // 
            // NewSecurityAnswerInputTextBox
            // 
            this.NewSecurityAnswerInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSecurityAnswerInputTextBox.Location = new System.Drawing.Point(267, 330);
            this.NewSecurityAnswerInputTextBox.Multiline = true;
            this.NewSecurityAnswerInputTextBox.Name = "NewSecurityAnswerInputTextBox";
            this.NewSecurityAnswerInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NewSecurityAnswerInputTextBox.Size = new System.Drawing.Size(469, 73);
            this.NewSecurityAnswerInputTextBox.TabIndex = 12;
            // 
            // NewConfirmInputTextBox
            // 
            this.NewConfirmInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewConfirmInputTextBox.Location = new System.Drawing.Point(267, 214);
            this.NewConfirmInputTextBox.Name = "NewConfirmInputTextBox";
            this.NewConfirmInputTextBox.Size = new System.Drawing.Size(469, 23);
            this.NewConfirmInputTextBox.TabIndex = 10;
            // 
            // NewPassInputTextBox
            // 
            this.NewPassInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassInputTextBox.Location = new System.Drawing.Point(267, 160);
            this.NewPassInputTextBox.Name = "NewPassInputTextBox";
            this.NewPassInputTextBox.Size = new System.Drawing.Size(469, 23);
            this.NewPassInputTextBox.TabIndex = 9;
            // 
            // NewUserInputTextBox
            // 
            this.NewUserInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUserInputTextBox.Location = new System.Drawing.Point(267, 108);
            this.NewUserInputTextBox.Name = "NewUserInputTextBox";
            this.NewUserInputTextBox.Size = new System.Drawing.Size(469, 23);
            this.NewUserInputTextBox.TabIndex = 8;
            this.NewUserInputTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RegisterAccountLabel
            // 
            this.RegisterAccountLabel.AutoSize = true;
            this.RegisterAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterAccountLabel.Location = new System.Drawing.Point(41, 33);
            this.RegisterAccountLabel.Name = "RegisterAccountLabel";
            this.RegisterAccountLabel.Size = new System.Drawing.Size(292, 31);
            this.RegisterAccountLabel.TabIndex = 7;
            this.RegisterAccountLabel.Text = "Register a New Acount";
            // 
            // RegisterGoBackButton
            // 
            this.RegisterGoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterGoBackButton.Location = new System.Drawing.Point(391, 498);
            this.RegisterGoBackButton.Name = "RegisterGoBackButton";
            this.RegisterGoBackButton.Size = new System.Drawing.Size(189, 29);
            this.RegisterGoBackButton.TabIndex = 6;
            this.RegisterGoBackButton.Text = "Go back";
            this.RegisterGoBackButton.UseVisualStyleBackColor = true;
            // 
            // RegisterAccountButton
            // 
            this.RegisterAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterAccountButton.Location = new System.Drawing.Point(375, 447);
            this.RegisterAccountButton.Name = "RegisterAccountButton";
            this.RegisterAccountButton.Size = new System.Drawing.Size(223, 45);
            this.RegisterAccountButton.TabIndex = 5;
            this.RegisterAccountButton.Text = "Register account";
            this.RegisterAccountButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Security Answer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Security Question";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // ForgetButton
            // 
            this.ForgetButton.Location = new System.Drawing.Point(326, 450);
            this.ForgetButton.Name = "ForgetButton";
            this.ForgetButton.Size = new System.Drawing.Size(162, 45);
            this.ForgetButton.TabIndex = 5;
            this.ForgetButton.Text = "Forgot login credentials";
            this.ForgetButton.UseVisualStyleBackColor = true;
            // 
            // LogInButton
            // 
            this.LogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.Location = new System.Drawing.Point(326, 381);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(334, 61);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LogInTitle
            // 
            this.LogInTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogInTitle.AutoSize = true;
            this.LogInTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInTitle.Location = new System.Drawing.Point(292, 33);
            this.LogInTitle.Name = "LogInTitle";
            this.LogInTitle.Size = new System.Drawing.Size(414, 76);
            this.LogInTitle.TabIndex = 3;
            this.LogInTitle.Text = "Projectaholic";
            // 
            // LogPassLabel
            // 
            this.LogPassLabel.AutoSize = true;
            this.LogPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogPassLabel.Location = new System.Drawing.Point(99, 277);
            this.LogPassLabel.Name = "LogPassLabel";
            this.LogPassLabel.Size = new System.Drawing.Size(98, 25);
            this.LogPassLabel.TabIndex = 3;
            this.LogPassLabel.Text = "Password";
            this.LogPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogPassLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // LogUserLabel
            // 
            this.LogUserLabel.AutoSize = true;
            this.LogUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogUserLabel.Location = new System.Drawing.Point(99, 189);
            this.LogUserLabel.Name = "LogUserLabel";
            this.LogUserLabel.Size = new System.Drawing.Size(102, 25);
            this.LogUserLabel.TabIndex = 2;
            this.LogUserLabel.Text = "Username";
            this.LogUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.LogInMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "Login to Your Projectaholic Account";
            this.LogInMainPanel.ResumeLayout(false);
            this.LogInMainPanel.PerformLayout();
            this.ForgetCredentialsPanel.ResumeLayout(false);
            this.ForgetCredentialsPanel.PerformLayout();
            this.RecoveryPartThreePanel.ResumeLayout(false);
            this.RecoveryPartThreePanel.PerformLayout();
            this.RecoveryPartTwoPanel.ResumeLayout(false);
            this.RecoveryPartTwoPanel.PerformLayout();
            this.RecoverPartOnePanel.ResumeLayout(false);
            this.RecoverPartOnePanel.PerformLayout();
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LogUserInputTextBox;
        private System.Windows.Forms.TextBox LogPassInputTextBox;
        private System.Windows.Forms.Panel LogInMainPanel;
        private System.Windows.Forms.Label LogPassLabel;
        private System.Windows.Forms.Label LogUserLabel;
        private System.Windows.Forms.Label LogInTitle;
        private System.Windows.Forms.Button NewAccountButton;
        private System.Windows.Forms.Button ForgetButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.TextBox NewSecurityAnswerInputTextBox;
        private System.Windows.Forms.TextBox NewConfirmInputTextBox;
        private System.Windows.Forms.TextBox NewPassInputTextBox;
        private System.Windows.Forms.TextBox NewUserInputTextBox;
        private System.Windows.Forms.Label RegisterAccountLabel;
        private System.Windows.Forms.Button RegisterGoBackButton;
        private System.Windows.Forms.Button RegisterAccountButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ForgetCredentialsPanel;
        private System.Windows.Forms.ComboBox NewSecurityQuestionComboBox;
        private System.Windows.Forms.Label SecurityAnswerErrorLabel;
        private System.Windows.Forms.Label SecurityQuestionErrorLabel;
        private System.Windows.Forms.Label ConfirmErrorLabel;
        private System.Windows.Forms.Label PassInputErrorLabel;
        private System.Windows.Forms.Label UserInputErrorLabel;
        private System.Windows.Forms.Label RecoveryLabel;
        private System.Windows.Forms.Panel RecoverPartOnePanel;
        private System.Windows.Forms.TextBox RecoveryPart1UserTextBox;
        private System.Windows.Forms.Label RecoveryPart1Label;
        private System.Windows.Forms.Button RecoveryBackButton;
        private System.Windows.Forms.Button RecoveryNextButton;
        private System.Windows.Forms.Label RecoveryPart1UserErrorLabel;
        private System.Windows.Forms.Panel RecoveryPartThreePanel;
        private System.Windows.Forms.Label RecoveryPart3PassErrorLabel;
        private System.Windows.Forms.TextBox RecoveryPart3NewTextBox;
        private System.Windows.Forms.Label RecoveryPart3NewPassLabel;
        private System.Windows.Forms.Label RecoveryPart3Label;
        private System.Windows.Forms.Panel RecoveryPartTwoPanel;
        private System.Windows.Forms.TextBox RecoveryPart2AnswerTextBox;
        private System.Windows.Forms.Label SecurityQuestionPart2Label;
        private System.Windows.Forms.Label RecoveryPart2Label;
        private System.Windows.Forms.Label RecoveryPart3ConfirmErrorLabel;
        private System.Windows.Forms.TextBox RecoveryPart3ConfirmTextBox;
        private System.Windows.Forms.Label RecoveryPart3ConfirmLabel;
    }
}