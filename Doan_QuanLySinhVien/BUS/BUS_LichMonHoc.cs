﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
   public class BUS_LichMonHoc
    {
        DAL_LichMonHoc dal_lichMonHoc = new DAL_LichMonHoc();

        public DataTable getData_LichMonHoc_GV_MH()
        {
            return dal_lichMonHoc.getDataLichMH_GV_Mh();
        }
    }
}
