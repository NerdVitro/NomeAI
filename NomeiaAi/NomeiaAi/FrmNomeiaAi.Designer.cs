namespace NomeiaAi
{
    partial class FrmNomeiaAi
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
            panel1 = new Panel();
            LblResultadoSimples = new Label();
            TxbResultadoSimples = new TextBox();
            CkbController = new CheckBox();
            CkbBusinessObjects = new CheckBox();
            BtnCopiar = new Button();
            DgvResultado = new DataGridView();
            LblResultado = new Label();
            LblDescricao = new Label();
            TxbNome = new TextBox();
            BtnGerar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvResultado).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(LblResultadoSimples);
            panel1.Controls.Add(TxbResultadoSimples);
            panel1.Controls.Add(CkbController);
            panel1.Controls.Add(CkbBusinessObjects);
            panel1.Controls.Add(BtnCopiar);
            panel1.Controls.Add(DgvResultado);
            panel1.Controls.Add(LblResultado);
            panel1.Controls.Add(LblDescricao);
            panel1.Controls.Add(TxbNome);
            panel1.Controls.Add(BtnGerar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 467);
            panel1.TabIndex = 0;
            // 
            // LblResultadoSimples
            // 
            LblResultadoSimples.AutoSize = true;
            LblResultadoSimples.Location = new Point(14, 136);
            LblResultadoSimples.Name = "LblResultadoSimples";
            LblResultadoSimples.Size = new Size(103, 15);
            LblResultadoSimples.TabIndex = 13;
            LblResultadoSimples.Text = "Resultado Simples";
            // 
            // TxbResultadoSimples
            // 
            TxbResultadoSimples.Location = new Point(14, 154);
            TxbResultadoSimples.Name = "TxbResultadoSimples";
            TxbResultadoSimples.Size = new Size(382, 23);
            TxbResultadoSimples.TabIndex = 12;
            // 
            // CkbController
            // 
            CkbController.AutoSize = true;
            CkbController.Location = new Point(144, 94);
            CkbController.Name = "CkbController";
            CkbController.Size = new Size(79, 19);
            CkbController.TabIndex = 11;
            CkbController.Text = "Controller";
            CkbController.UseVisualStyleBackColor = true;
            CkbController.CheckedChanged += CkbController_CheckedChanged;
            // 
            // CkbBusinessObjects
            // 
            CkbBusinessObjects.AutoSize = true;
            CkbBusinessObjects.Checked = true;
            CkbBusinessObjects.CheckState = CheckState.Checked;
            CkbBusinessObjects.Location = new Point(144, 69);
            CkbBusinessObjects.Name = "CkbBusinessObjects";
            CkbBusinessObjects.Size = new Size(141, 19);
            CkbBusinessObjects.TabIndex = 10;
            CkbBusinessObjects.Text = "BO (Business Objects)";
            CkbBusinessObjects.UseVisualStyleBackColor = true;
            CkbBusinessObjects.CheckedChanged += CkbBusinessObjects_CheckedChanged;
            // 
            // BtnCopiar
            // 
            BtnCopiar.BackColor = SystemColors.Window;
            BtnCopiar.FlatAppearance.BorderSize = 0;
            BtnCopiar.FlatStyle = FlatStyle.Flat;
            BtnCopiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCopiar.Location = new Point(314, 60);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(81, 51);
            BtnCopiar.TabIndex = 9;
            BtnCopiar.Text = "Copiar";
            BtnCopiar.UseVisualStyleBackColor = false;
            BtnCopiar.Click += BtnCopiar_Click;
            // 
            // DgvResultado
            // 
            DgvResultado.AllowUserToAddRows = false;
            DgvResultado.AllowUserToDeleteRows = false;
            DgvResultado.AllowUserToResizeColumns = false;
            DgvResultado.AllowUserToResizeRows = false;
            DgvResultado.BackgroundColor = SystemColors.Window;
            DgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvResultado.ColumnHeadersVisible = false;
            DgvResultado.Location = new Point(13, 198);
            DgvResultado.MultiSelect = false;
            DgvResultado.Name = "DgvResultado";
            DgvResultado.ReadOnly = true;
            DgvResultado.RowHeadersVisible = false;
            DgvResultado.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvResultado.RowTemplate.Height = 25;
            DgvResultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvResultado.ShowCellErrors = false;
            DgvResultado.ShowCellToolTips = false;
            DgvResultado.ShowEditingIcon = false;
            DgvResultado.ShowRowErrors = false;
            DgvResultado.Size = new Size(382, 257);
            DgvResultado.TabIndex = 6;
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Location = new Point(14, 180);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(59, 15);
            LblResultado.TabIndex = 5;
            LblResultado.Text = "Resultado";
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(13, 13);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(58, 15);
            LblDescricao.TabIndex = 4;
            LblDescricao.Text = "Descrição";
            // 
            // TxbNome
            // 
            TxbNome.Location = new Point(13, 31);
            TxbNome.Name = "TxbNome";
            TxbNome.Size = new Size(382, 23);
            TxbNome.TabIndex = 3;
            // 
            // BtnGerar
            // 
            BtnGerar.BackColor = SystemColors.Window;
            BtnGerar.FlatAppearance.BorderSize = 0;
            BtnGerar.FlatStyle = FlatStyle.Flat;
            BtnGerar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGerar.Location = new Point(12, 60);
            BtnGerar.Name = "BtnGerar";
            BtnGerar.Size = new Size(81, 51);
            BtnGerar.TabIndex = 2;
            BtnGerar.Text = "Gerar";
            BtnGerar.UseVisualStyleBackColor = false;
            BtnGerar.Click += BtnGerar_Click;
            // 
            // FrmNomeiaAi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 467);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNomeiaAi";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NomeAI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvResultado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LblResultado;
        private Label LblDescricao;
        private TextBox TxbNome;
        private Button BtnGerar;
        private DataGridView DgvResultado;
        private CheckBox CkbController;
        private CheckBox CkbBusinessObjects;
        private Button BtnCopiar;
        private Label LblResultadoSimples;
        private TextBox TxbResultadoSimples;
    }
}