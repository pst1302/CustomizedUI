using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerlizedUI
{
    public partial class Form1 : Form
    {
        int howManyPaint = 1;

        public Form1()
        {
            InitializeComponent();

            paintingPanel.AutoScroll = true;

        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            howManyPaint = Convert.ToInt32(((ComboBox)sender).Text);

            paintingPanel.Refresh();
        }

        private void paintingPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        public void calculateRecByItemNum(RectangleF[] rectangleArr, int itemNum)
        {
            
            initRecArr(rectangleArr, itemNum);  // 초기화 수행

            setItemsLocations(rectangleArr, itemNum);
        }

        // RectangleF를 Item 개수 만큼 초기화
        private void initRecArr(RectangleF[] rectangleArr, int itemNum)
        {
            rectangleArr = new RectangleF[itemNum];
            for (int i = 0; i < itemNum; i++)
            {
                rectangleArr[i] = new RectangleF();
            }
        }

        // Rectangle의 Locations 설정
        private void setItemsLocations(RectangleF[] rectangleArr, int itemNum)
        {
            
        }
    }
}
