using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerlizedUI
{
    /*
     *  parent Panel과 rectanlgef와 그 안에 들어가는 Item을 읽어들여서 계산해주는 클래스
     *  
     */
    class RecCalculator
    {
        public void calculateRecByItemNum(Panel parentPanel, RectangleF[] rectangleArr, int itemNum)
        {
            
            initRecArr(rectangleArr, itemNum);  // 초기화 수행

            setItemsSize(parentPanel, rectangleArr, itemNum);
            setItemsLocations(parentPanel,rectangleArr, itemNum);
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

        // Item 개수별 Rectangle의 크기 조절
        private void setItemsSize(Panel parentPanel, RectangleF[] rectangleArr, int itemNum)
        {
            int parentWidth;
            int parentHeight;

            parentWidth = parentPanel.Width;
            parentHeight = parentPanel.Height;


            if (itemNum == 1)
            {
                setSize(rectangleArr, parentWidth, parentHeight);
            }
            else if (itemNum == 2)
            {
                setSize(rectangleArr, parentWidth, parentHeight / 2);
            }
            else if (itemNum > 2 && itemNum <= 4)
            {
                setSize(rectangleArr, parentWidth / 2, parentHeight / 2);
            }
            else if (itemNum > 4 && itemNum <= 8)
            {
                setSize(rectangleArr, parentWidth / 3, parentHeight / 3);
            }
            else if (itemNum > 8 && itemNum <= 16)
            {
                setSize(rectangleArr, parentWidth / 4, parentHeight / 4);
            }
            else if (itemNum > 16 && itemNum <= 32)
            {
                setSize(rectangleArr, parentWidth / 5, parentHeight / 5);
            }
            else if (itemNum > 32 && itemNum <= 64)
            {
                setSize(rectangleArr, parentWidth / 6, parentHeight / 6);
            }
            else if (itemNum > 64 && itemNum <= 128)
            {
                setSize(rectangleArr, parentWidth / 7, parentHeight / 7);
            }
            else
            {
                return;
            }
        }

        // 실제로 rectangleF 구조체의 너비와 높이를 설정하는 함수
        private void setSize(RectangleF[] rectangleArr, int width, int height)
        {
            for(int i = 0; i < rectangleArr.Length; i++)
            {
                rectangleArr[i].Width = width;
                rectangleArr[i].Height = height;
            }
        }

        // item 개수에 따라 rectangleF 구조체의 Location을 설정하는 부분
        private void setItemsLocations(Panel parentPanel, RectangleF[] rectangleArr, int itemNum)
        {
            int parentWidth;
            int parentHeight;

            parentWidth = parentPanel.Width;
            parentHeight = parentPanel.Height;


            if (itemNum == 1)
            {
                setLocations(rectangleArr, 1, 1);
            }
            else if (itemNum == 2)
            {

            }
            else if (itemNum > 2 && itemNum <= 4)
            {

            }
            else if (itemNum > 4 && itemNum <= 8)
            {

            }
            else if (itemNum > 8 && itemNum <= 16)
            {

            }
            else if (itemNum > 16 && itemNum <= 32)
            {

            }
            else if (itemNum > 32 && itemNum <= 64)
            {

            }
            else if (itemNum > 64 && itemNum <= 128)
            {

            }
            else
            {
                return;
            }
        }

        private void setLocations(RectangleF[] rectangleArr, int low, int col)
        {
            int j = 0;

            for (int i = 0; i < low; i++)
            {
                
            }
        }
    }
}
