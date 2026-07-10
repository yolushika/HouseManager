using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 房屋租赁系统.Models
{
    public class House
    {
        private string Hno;
        private string Hname;
        private string Haera;
        private string Hfloor;
        private string Hrent;
        private string Hcount;
        private int Hc_no;
        private string Hstate;
        private string Cname;

        public string Hno1 { get => Hno; set => Hno = value; }
        public string Hname1 { get => Hname; set => Hname = value; }
        public string Harea1 { get => Haera; set => Haera = value; }
        public string Hfloor1 { get => Hfloor; set => Hfloor = value; }
        public string Hrent1 { get => Hrent; set => Hrent = value; }
        public string Hcount1 { get => Hcount; set => Hcount = value; }
        public int Hc_no1 { get => Hc_no; set => Hc_no = value; }
        public string Hstate1 { get => Hstate; set => Hstate = value; }
        public string Cname1 { get => Cname; set => Cname = value; }
    }
}
