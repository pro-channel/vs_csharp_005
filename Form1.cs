using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vs_csharp_005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 5;
            int b = -7;

            int value = this.Sum(a, b);
        }

        /// <summary>
        /// 第1、第2の引数を加算した値を返します。
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private int Sum(int left, int right)
        {
            int result = left + right;
            return result;
        }

        /// <summary>
        /// ラベルへ引数の値を設定します。
        /// </summary>
        /// <param name="text"></param>
        private void SetText(string text)
        {
            this.label.Text = text;
        }

        /// <summary>
        /// ラベルへ表示の文字を設定します。
        /// </summary>
        private void SetDisplayText()
        {
            this.label.Text = "表示";
        }
    }
}
