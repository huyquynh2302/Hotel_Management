using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_Hotel;

namespace DAL_Hotel
{
    public class DAL_DangKi : DBConnect
    {
  
        public bool themDangKi(DTO_DangKi dk)
        {
            try
            {
                con.Open();
                string SQL = string.Format("INSERT INTO DANGKI(TENDANGNHAP,MATKHAU,HOTEN,EMAIL,SODIENTHOAI,DIACHI) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", dk.DANGKI_TK, dk.DANGKI_MK, dk.DANGKI_NAME, dk.DANGKI_EMAIL, dk.DANGKI_PHONENUMBER, dk.DANGKI_DIACHI);
                SqlCommand cmd = new SqlCommand(SQL, con);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public bool DangNhap(DTO_DangKi dn)
        {
            try
            {
                con.Open();
                string SQL = string.Format("SELECT TENDANGNHAP, MATKHAU FROM DANGKI WHERE TENDANGNHAP = '{0}' AND MATKHAU = '{1}'", dn.DANGKI_TK, dn.DANGKI_MK);
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataReader data = cmd.ExecuteReader();
                if(data.Read() == true)
                {
                    return true;
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return false;
        }



    }

}
