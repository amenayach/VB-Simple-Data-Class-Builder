using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleDataClassBuilder
{
    public partial class MainFrm : Form
    {
        string[] types = new string[] { "Boolean", "String", "Integer", "Short", "Long", "Double", "Decimal", "Single", "Char", "DateTime" };

        public MainFrm()
        {
            InitializeComponent();
            FType.Items.AddRange(types);
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbClassName.Text))
                {
                    Blinker.Blink(tbClassName, Color.Orange, Color.White);
                    return;
                }

                grd.AllowUserToAddRows = false;
                if (grd.Rows.Count > 0)
                {
                    var sb = new StringBuilder();
                    sb.Append("Public Class " + tbClassName.Text + Environment.NewLine);

                    for (int i = 0; i < grd.RowCount; i++)
                    {
                        var pname = GetCellValue(i, FName);
                        var ptype = (String.IsNullOrEmpty(GetCellValue(i, FCustom)) ? GetCellValue(i, FType) : GetCellValue(i, FCustom));
                        if (String.IsNullOrEmpty(pname))
                        {
                            grd.Rows[i].Cells[FName.Index].Style.BackColor = Color.Orange;
                            grd.Rows[i].Cells[FName.Index].Style.SelectionBackColor = Color.DarkOrange;
                            return;
                        }

                        if (String.IsNullOrEmpty(ptype))
                        {
                            grd.Rows[i].Cells[FType.Index].Style.BackColor = Color.Orange;
                            grd.Rows[i].Cells[FCustom.Index].Style.BackColor = Color.Orange;
                            grd.Rows[i].Cells[FCustom.Index].Style.SelectionBackColor = Color.DarkOrange;
                            return;
                        }

                        grd.Rows[i].Cells[FName.Index].Style.BackColor = Color.White;
                        grd.Rows[i].Cells[FType.Index].Style.BackColor = Color.White;
                        grd.Rows[i].Cells[FCustom.Index].Style.BackColor = Color.White;
                        grd.Rows[i].Cells[FCustom.Index].Style.SelectionBackColor = System.Drawing.SystemColors.Highlight;
                        grd.Rows[i].Cells[FName.Index].Style.SelectionBackColor = System.Drawing.SystemColors.Highlight;

                        sb.Append(String.Format(@"
    Private _{0} As {1}
    Public Property {0}() As {1}
        Get
            Return _{0}
        End Get
        Set(ByVal value As {1})
            _{0} = value
        End Set
    End Property

", pname, ptype));

                    }

                    sb.Append("End Class ");

                    System.IO.File.WriteAllText(System.IO.Path.Combine(Application.StartupPath, tbClassName.Text + ".vb"), sb.ToString());

                    MessageBox.Show("Done");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                grd.AllowUserToAddRows = true;
            }
        }

        private string GetCellValue(int index, DataGridViewColumn Col)
        {
            return grd.Rows[index].Cells[Col.Index].Value as string;
        }
    }
}
