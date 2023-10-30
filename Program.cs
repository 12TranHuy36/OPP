using System;
namespace Thigiuaky
{
    class Danso
    {
        private string SoCCCD, Ten, Gioitinh, Tuoi, NgheNghiep;
        private string [,] DS=new string [100,5];
        public void Nhap()
        {
            String input=File.ReadAllText(@"thi.txt");
            int i=0,j=0;
            foreach(var row in input.Split("\n"))
            {
                j=0;
                foreach(var col in row.Trim().Split(";"))
                {
                    if (j==0)
                    {
                        SoCCCD=col.Trim();
                        DS[i,0]=SoCCCD;
                        Console.Write(col);
                    }
                    else if (j==1)
                    {
                        Ten=col.Trim();
                        DS[i,1]=Ten;
                        Console.Write(col);
                    }
                    else if (j==2)
                    {
                        Gioitinh=col.Trim();
                        DS[i,2]=Gioitinh;
                        Console.Write(col);
                    }
                    else if (j==3)
                    {
                        Tuoi=col.Trim();
                        DS[i,3]=Tuoi;
                        Console.Write(col);
                    }
                    else if (j==4)
                    {
                        NgheNghiep=col.Trim();
                        DS[i,4]=NgheNghiep;
                        Console.Write(col);
                    }
                    j++;
                }
                i++;
                Console.WriteLine();
            }
        }
        public void Them()
        {
            Console.Write("Nhap so luong can them: ");
            int a=int.Parse(Console.ReadLine());
            int d=0;
            for (int i=0;i<DS.GetLength(0);i++)
            {
                if (DS[i,0]!=null) d++;
            }
            for (int i=d;i<d+a;i++)
            {
                for(int j=0;j<5;j++)
                {
                    if(j==0)
                    {
                        Console.Write("Nhap so CCCD: ");
                        SoCCCD=Console.ReadLine();
                        DS[i,0]=SoCCCD;
                    }
                    else if(j==1)
                    {
                        Console.Write("\tTen: ");
                        Ten=Console.ReadLine();
                        DS[i,1]=Ten;
                    }
                    else if(j==2)
                    {
                        Console.Write("\tGioi tinh: ");
                        Gioitinh=Console.ReadLine();
                        DS[i,2]=Gioitinh;
                    }
                    else if(j==3)
                    {
                        Console.Write("\tTuoi: ");
                        Tuoi=Console.ReadLine();
                        DS[i,3]=Tuoi;
                    }
                    else if(j==4)
                    {
                        Console.Write("\tNghe nghiep: ");
                        NgheNghiep =Console.ReadLine();
                        DS[i,4]=NgheNghiep;
                    }
                }
                
            }
            Console.WriteLine(" DANH SACH MOI THEM");
            for(int i=0;i<DS.GetLength(0);i++)
            {
                if(DS[i,0]!=null)
                {
                    for(int j=0;j<5;j++)
                    {
                        Console.Write("{0}\t",DS[i,j]);
                    }
                    Console.WriteLine();
                }
                
            }
        }
        public void Sosanh()
        {
            int nam=0,nu=0;
            for(int i=0;i<DS.GetLength(0);i++)
            {
                if(DS[i,2]=="Nam") nam++;
                else if (DS[i,2]=="Nu") nu++;
            }
            Console.WriteLine("So luong Nam la: {0}",nam);
            Console.WriteLine("So luong Nu la: {0}",nu);
        }
        public void Tracuu()
        {
            double d=0;
            double dem=0;
            for(int i=0;i<DS.GetLength(0);i++)
            {
                if (DS[i,0]!=null) d+=1;
            }
            for (int i=0;i<DS.GetLength(0);i++)
            {
                if (DS[i,3]!=null)
                {
                    int t=int.Parse(DS[i,3]);
                    if (18<=t & t<=50)
                    {
                        dem+=1;
                        for(int j=0;j<5;j++)
                        {
                            Console.Write("{0}\t",DS[i,j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
            
            double s=(dem/d);
            Console.WriteLine("Do tuoi da neu tren chiem {0} phan tram trong danh sach hien co",s*100);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Danso a=new Danso();
            a.Nhap();
            while (true)
            {
                Console.Write("Bam chon: ");
                int cd=int.Parse(Console.ReadLine());
                if (cd==0) break;
                else if (cd==1) a.Them();
                else if (cd==2) a.Sosanh();
                else if (cd==3) a.Tracuu();

            }
        }
    }
}
