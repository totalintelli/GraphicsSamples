namespace GraphicsSamples
{
    partial class GraphicsSamplesForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRotateTransform = new System.Windows.Forms.Button();
            this.btnSetClipPathCombine = new System.Windows.Forms.Button();
            this.btnDrawString = new System.Windows.Forms.Button();
            this.btnSetAndFillClip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRotateTransform
            // 
            this.btnRotateTransform.Location = new System.Drawing.Point(12, 444);
            this.btnRotateTransform.Name = "btnRotateTransform";
            this.btnRotateTransform.Size = new System.Drawing.Size(113, 23);
            this.btnRotateTransform.TabIndex = 0;
            this.btnRotateTransform.Text = "RotateTransform";
            this.btnRotateTransform.UseVisualStyleBackColor = true;
            this.btnRotateTransform.Click += new System.EventHandler(this.btn_Clicked);
            // 
            // btnSetClipPathCombine
            // 
            this.btnSetClipPathCombine.Location = new System.Drawing.Point(131, 444);
            this.btnSetClipPathCombine.Name = "btnSetClipPathCombine";
            this.btnSetClipPathCombine.Size = new System.Drawing.Size(139, 23);
            this.btnSetClipPathCombine.TabIndex = 1;
            this.btnSetClipPathCombine.Text = "SetClipPathCombine";
            this.btnSetClipPathCombine.UseVisualStyleBackColor = true;
            this.btnSetClipPathCombine.Click += new System.EventHandler(this.btn_Clicked);
            // 
            // btnDrawString
            // 
            this.btnDrawString.Location = new System.Drawing.Point(277, 444);
            this.btnDrawString.Name = "btnDrawString";
            this.btnDrawString.Size = new System.Drawing.Size(75, 23);
            this.btnDrawString.TabIndex = 2;
            this.btnDrawString.Text = "DrawString";
            this.btnDrawString.UseVisualStyleBackColor = true;
            // 
            // btnSetAndFillClip
            // 
            this.btnSetAndFillClip.Location = new System.Drawing.Point(359, 444);
            this.btnSetAndFillClip.Name = "btnSetAndFillClip";
            this.btnSetAndFillClip.Size = new System.Drawing.Size(95, 23);
            this.btnSetAndFillClip.TabIndex = 3;
            this.btnSetAndFillClip.Text = "SetAndFillClip";
            this.btnSetAndFillClip.UseVisualStyleBackColor = true;
            // 
            // GraphicsSamplesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 479);
            this.Controls.Add(this.btnSetAndFillClip);
            this.Controls.Add(this.btnDrawString);
            this.Controls.Add(this.btnSetClipPathCombine);
            this.Controls.Add(this.btnRotateTransform);
            this.Name = "GraphicsSamplesForm";
            this.Text = "그래픽 샘플들";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphicsSamplesForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRotateTransform;
        private System.Windows.Forms.Button btnSetClipPathCombine;
        private System.Windows.Forms.Button btnDrawString;
        private System.Windows.Forms.Button btnSetAndFillClip;
    }
}

