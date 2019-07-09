using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Label[,] grid = new Label[4, 4];

        int ifmove = 1;

        public Form1()
        {
            int x, y;
            bool done = false;
            InitializeComponent();
            grid[0, 0] = a1; grid[0, 1] = b1; grid[0, 2] = c1; grid[0, 3] = d1;
            grid[1, 0] = a2; grid[1, 1] = b2; grid[1, 2] = c2; grid[1, 3] = d2;
            grid[2, 0] = a3; grid[2, 1] = b3; grid[2, 2] = c3; grid[2, 3] = d3;
            grid[3, 0] = a4; grid[3, 1] = b4; grid[3, 2] = c4; grid[3, 3] = d4;
            Random rnd = new Random();
            x = rnd.Next(0, 4);
            y = rnd.Next(0, 4);
            grid[x, y].Text = "2";
            do
            {

                x = rnd.Next(0, 4);
                y = rnd.Next(0, 4);
                if (grid[x, y].Text == "")
                {
                    grid[x, y].Text = "2";
                    done = true;
                }
            } while (!done );
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            bool done = false;
            int x, y,full=0;
            
            int[] a = new int[3];
            Random rnd = new Random();
            
//         do
 //           {
                if (e.KeyCode == Keys.Up)
                {
                    for (int j = 0; j < 4; j++)
                    {
           //             for(int k = 0; k < 3; k++)    //判斷是否有可以推
            //            {
            //                if (grid[k, j].Text != grid[k + 1, j].Text)
            //                    ifmove++;
            //            }

                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = k; l < 3; l++)
                            {
                                if (grid[l, j].Text == "")
                                {
                                    grid[l, j].Text = grid[l + 1, j].Text;
                                    grid[l + 1, j].Text = "";
                                                
                                }
                            }
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            if (grid[i, j].Text == grid[i + 1, j].Text && grid[i, j].Text != "")
                            {
                                grid[i + 1, j].Text = "";
                                grid[i, j].Text = (Convert.ToInt64(grid[i, j].Text) * 2).ToString();                     
                            }
                        }
                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = k; l < 3; l++)
                            {
                                if (grid[l, j].Text == "")
                                {
                                    grid[l, j].Text = grid[l + 1, j].Text;
                                    grid[l + 1, j].Text = "";
                                }
                            }
                        }
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    for (int j = 0; j < 4; j++)
                    {
              //          for (int k = 3; k >0; k--)    //判斷是否有可以推
              //          {
              //              if (grid[k, j].Text != grid[k - 1, j].Text)
               //                 ifmove++;
               //         }

                        for (int k = 3; k >= 0; k--)
                        {
                            for (int l = k; l > 0; l--)
                            {
                                if (grid[l, j].Text == "")
                                {
                                    grid[l, j].Text = grid[l - 1, j].Text;
                                    grid[l - 1, j].Text = "";                                    
                                }
                            }
                        }
                        for (int i = 3; i > 0; i--)
                        {
                            if (grid[i, j].Text == grid[i - 1, j].Text && grid[i, j].Text != "")
                            {
                                grid[i - 1, j].Text = "";
                                grid[i, j].Text = (Convert.ToInt64(grid[i, j].Text) * 2).ToString();
                                
                            }
                        }
                        for (int k = 3; k >= 0; k--)
                        {
                            for (int l = k; l > 0; l--)
                            {
                                if (grid[l, j].Text == "")
                                {
                                    grid[l, j].Text = grid[l - 1, j].Text;
                                    grid[l - 1, j].Text = "";
                                }
                            }
                        }
                    }
                }
                if (e.KeyCode == Keys.Left)
                {
                    for (int i = 0; i < 4; i++)
                    {
               //         for (int k = 0; k < 3; k++)    //判斷是否有可以推
               //         {
                //            if (grid[i,k].Text != grid[i,k + 1].Text)
                //                ifmove++;
                //        }
                        for (int k = 0; k < 4; k++)
                        {
                            for (int l = 0; l < 3 - k; l++)
                            {
                                if (grid[i, l].Text == "")
                                {
                                    grid[i, l].Text = grid[i, l + 1].Text;
                                    grid[i, l + 1].Text = "";                                 
                                }
                            }
                        }
                        for (int j = 0; j < 3; j++)
                        {
                            if (grid[i, j].Text == grid[i, j + 1].Text && grid[i, j].Text != "")
                            {
                                grid[i, j + 1].Text = "";
                                grid[i, j].Text = (Convert.ToInt64(grid[i, j].Text) * 2).ToString();                      
                            }
                        }
                        for (int k = 0; k < 4; k++)
                        {
                            for (int l = 0; l < 3 - k; l++)
                            {
                                if (grid[i, l].Text == "")
                                {
                                    grid[i, l].Text = grid[i, l + 1].Text;
                                    grid[i, l + 1].Text = "";
                                }
                            }
                        }
                    }
                }
                if (e.KeyCode == Keys.Right)
                {
                    for (int i = 0; i < 4; i++)
                    {
              //          for (int k = 3; k >0; k--)    //判斷是否有可以推
              //          {
              //              if (grid[i, k].Text != grid[i, k -1].Text)
               //                 ifmove++;
              //          }
                        for (int k = 0; k < 4; k++)
                        {
                            for (int l = 3; l > k; l--)
                            {
                                if (grid[i, l].Text == "")
                                {
                                    grid[i, l].Text = grid[i, l - 1].Text;
                                    grid[i, l - 1].Text = "";
                                    ifmove = 0;
                                }
                            }
                        }
                        for (int j = 3; j > 0; j--)
                        {
                            if (grid[i, j].Text == grid[i, j - 1].Text && grid[i, j].Text != "")
                            {
                                grid[i, j - 1].Text = "";
                                grid[i, j].Text = (Convert.ToInt64(grid[i, j].Text) * 2).ToString();
                                
                            }
                        }
                        for (int k = 0; k < 4; k++)
                        {
                            for (int l = 3; l > k; l--)
                            {
                                if (grid[i, l].Text == "")
                                {
                                    grid[i, l].Text = grid[i, l - 1].Text;
                                    grid[i, l - 1].Text = "";
                                }
                            }
                        }
                    }
                }
     //       } while (ifmove == 0) ;
     
      //          ifmove = 0;

            for (int i = 0; i < 3; i++)         //判斷是否滿
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j].Text != "")
                        full++;
                }
            }
            do                                  //random數字進去
            {

                x = rnd.Next(0, 4);
                y = rnd.Next(0, 4);
                if (grid[x, y].Text == "")
                {
                    grid[x, y].Text = "2";
                    done = true;
                }
            } while (!done && full != 16);


            for (int i = 0; i < 4; i++)             //上色
            {
                for (int j = 0; j < 4; j++)
                {
                    if (grid[i, j].Text == "2")
                    {
                        grid[i, j].BackColor = Color.Yellow;
                    }
                    if (grid[i, j].Text == "4")
                    {
                        grid[i, j].BackColor = Color.Orange;
                    }
                    if (grid[i, j].Text == "8")
                    {
                        grid[i, j].BackColor = Color.DarkOrange;
                    }
                    if (grid[i, j].Text == "16")
                    {
                        grid[i, j].BackColor = Color.OrangeRed;
                    }
                    if (grid[i, j].Text == "32")
                    {
                        grid[i, j].BackColor = Color.Red;
                    }
                    if (grid[i, j].Text == "64")
                    {
                        grid[i, j].BackColor = Color.PeachPuff;
                    }
                    if (grid[i, j].Text == "128")
                    {
                        grid[i, j].BackColor = Color.Purple;
                    }
                    else if (grid[i, j].Text == "")
                    {
                        grid[i, j].BackColor = Color.Gray;

                    }
                }
            }
        }
    }
}
