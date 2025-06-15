namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblNumberTwo = new System.Windows.Forms.Label();
            this.lblSing = new System.Windows.Forms.Label();
            this.lblNumberOne = new System.Windows.Forms.Label();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.lstHistoricoCompleto = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(23, 173);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(52, 49);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.NumeroClick);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(80, 173);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(52, 49);
            this.two.TabIndex = 15;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.NumeroClick);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(137, 173);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(52, 49);
            this.three.TabIndex = 16;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.NumeroClick);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(23, 228);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(52, 49);
            this.four.TabIndex = 17;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.NumeroClick);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(80, 228);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(52, 49);
            this.five.TabIndex = 18;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.NumeroClick);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(137, 228);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(52, 49);
            this.six.TabIndex = 19;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.NumeroClick);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(23, 282);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(52, 49);
            this.seven.TabIndex = 20;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.NumeroClick);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(80, 282);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(52, 49);
            this.eight.TabIndex = 21;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.NumeroClick);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(137, 282);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(52, 49);
            this.nine.TabIndex = 22;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.NumeroClick);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(196, 282);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(52, 49);
            this.equal.TabIndex = 23;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(196, 228);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(52, 49);
            this.minus.TabIndex = 24;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.OperacaoClick);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(196, 173);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(52, 49);
            this.plus.TabIndex = 25;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.OperacaoClick);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(23, 118);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(52, 49);
            this.clear.TabIndex = 26;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(137, 118);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(52, 49);
            this.mult.TabIndex = 27;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.OperacaoClick);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(80, 118);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(52, 49);
            this.div.TabIndex = 28;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.OperacaoClick);
            // 
            // backspace
            // 
            this.backspace.BackgroundImage = global::Calculadora.Properties.Resources.backspace_icon_151584__1_;
            this.backspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backspace.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(196, 118);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(52, 49);
            this.backspace.TabIndex = 29;
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Ubuntu Mono", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(23, 14);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult.Size = new System.Drawing.Size(230, 97);
            this.lblResult.TabIndex = 33;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblResult.Visible = false;
            // 
            // lblNumberTwo
            // 
            this.lblNumberTwo.Font = new System.Drawing.Font("Ubuntu Mono", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberTwo.ForeColor = System.Drawing.Color.White;
            this.lblNumberTwo.Location = new System.Drawing.Point(213, 38);
            this.lblNumberTwo.Name = "lblNumberTwo";
            this.lblNumberTwo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNumberTwo.Size = new System.Drawing.Size(40, 47);
            this.lblNumberTwo.TabIndex = 30;
            // 
            // lblSing
            // 
            this.lblSing.Font = new System.Drawing.Font("Ubuntu Mono", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSing.ForeColor = System.Drawing.Color.White;
            this.lblSing.Location = new System.Drawing.Point(170, 38);
            this.lblSing.Name = "lblSing";
            this.lblSing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSing.Size = new System.Drawing.Size(40, 47);
            this.lblSing.TabIndex = 31;
            // 
            // lblNumberOne
            // 
            this.lblNumberOne.Font = new System.Drawing.Font("Ubuntu Mono", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOne.ForeColor = System.Drawing.Color.White;
            this.lblNumberOne.Location = new System.Drawing.Point(124, 38);
            this.lblNumberOne.Name = "lblNumberOne";
            this.lblNumberOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNumberOne.Size = new System.Drawing.Size(40, 47);
            this.lblNumberOne.TabIndex = 32;
            // 
            // lblHistorico
            // 
            this.lblHistorico.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHistorico.Location = new System.Drawing.Point(102, 9);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(143, 29);
            this.lblHistorico.TabIndex = 34;
            this.lblHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(21, 14);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(75, 23);
            this.btnHistorico.TabIndex = 35;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            // 
            // lstHistoricoCompleto
            // 
            this.lstHistoricoCompleto.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstHistoricoCompleto.ForeColor = System.Drawing.SystemColors.Window;
            this.lstHistoricoCompleto.FullRowSelect = true;
            this.lstHistoricoCompleto.HideSelection = false;
            this.lstHistoricoCompleto.Location = new System.Drawing.Point(21, 43);
            this.lstHistoricoCompleto.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lstHistoricoCompleto.Name = "lstHistoricoCompleto";
            this.lstHistoricoCompleto.Size = new System.Drawing.Size(227, 288);
            this.lstHistoricoCompleto.TabIndex = 36;
            this.lstHistoricoCompleto.UseCompatibleStateImageBehavior = false;
            this.lstHistoricoCompleto.View = System.Windows.Forms.View.List;
            this.lstHistoricoCompleto.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(265, 357);
            this.Controls.Add(this.lstHistoricoCompleto);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumberOne);
            this.Controls.Add(this.lblSing);
            this.Controls.Add(this.lblNumberTwo);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblNumberTwo;
        private System.Windows.Forms.Label lblSing;
        private System.Windows.Forms.Label lblNumberOne;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.ListView lstHistoricoCompleto;
    }
}

