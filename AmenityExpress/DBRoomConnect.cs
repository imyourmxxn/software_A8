using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmenityExpress
{
    internal class DBRoomConnect
    {
        public static void LoadRoomData(ListView listView)
        {
            string sql = "SELECT NAME, ROOMNUM, PRICE, MAX_CLIENT, NOTICE, PHOTOPATH FROM ROOM_MANAGE";
            DataSet ds = DBConnector.DML_QUERY(sql,null);

            listView.Items.Clear();

            // 이미지 리스트 생성
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(50, 50); // 이미지 크기 조정 (가로, 세로)

            // 이미지를 표시할 이미지 리스트에 이미지 추가
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string imagePath = ds.Tables[0].Rows[i]["PHOTOPATH"].ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        // 이미지 리스트에 이미지 추가
                        imageList.Images.Add(Image.FromFile(imagePath));
                    }
                    catch (Exception ex)
                    {
                        // 이미지 로드 실패 시 처리할 내용
                        Console.WriteLine($"이미지 로드 실패: {ex.Message}");
                    }
                }
            }

            // 리스트뷰에 이미지 리스트 연결
            listView.SmallImageList = imageList;

            // 각 항목에 이미지 인덱스 설정하여 이미지 표시
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                ds.Tables[0].Rows[i]["NAME"].ToString(),
                ds.Tables[0].Rows[i]["ROOMNUM"].ToString(),
                ds.Tables[0].Rows[i]["PRICE"].ToString(),
                ds.Tables[0].Rows[i]["MAX_CLIENT"].ToString(),
                ds.Tables[0].Rows[i]["NOTICE"].ToString()
            });
                item.ImageIndex = i; // 이미지 인덱스 설정
                listView.Items.Add(item);
            }
        }
    }
}
