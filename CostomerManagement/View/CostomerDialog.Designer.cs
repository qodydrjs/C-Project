namespace CostomerManagement.View
{
    partial class CostomerDialog
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.MaskedTextBox();
            this.tb_address = new System.Windows.Forms.MaskedTextBox();
            this.tb_name = new System.Windows.Forms.MaskedTextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_phone);
            this.panel1.Controls.Add(this.tb_address);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 414);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "전화번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "이름";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(140, 190);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(324, 35);
            this.tb_phone.TabIndex = 16;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(140, 126);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(324, 35);
            this.tb_address.TabIndex = 15;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(140, 72);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(324, 35);
            this.tb_name.TabIndex = 14;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(314, 277);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(150, 66);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(158, 277);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 66);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "확인";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 20;
            // 
            // CostomerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CostomerDialog";
            this.Size = new System.Drawing.Size(466, 414);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tb_phone;
        private System.Windows.Forms.MaskedTextBox tb_address;
        private System.Windows.Forms.MaskedTextBox tb_name;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label1;
    }
}
