namespace AddinMainWithWindow
{
    public partial class SampleWindow
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.SayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SayHello
            // 
            this.SayHello.Location = new System.Drawing.Point(33, 41);
            this.SayHello.Name = "SayHello";
            this.SayHello.Size = new System.Drawing.Size(75, 23);
            this.SayHello.TabIndex = 0;
            this.SayHello.Text = "Say Hello";
            this.SayHello.UseVisualStyleBackColor = true;
            this.SayHello.Click += new System.EventHandler(this.SayHello_Click);
            // 
            // SampleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SayHello);
            this.Name = "SampleWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SayHello;
    }
}
