﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MPB.DAL;
using MPB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPB.DAL.Tests
{
    [TestClass()]
    public class SqlServerDALTests
    {
        /// <summary>
        /// 数据库数据操作对象
        /// </summary>
        private readonly SqlServerDAL _dal;
        public SqlServerDALTests()
        {
            SqlServerDAL.connectionString = "Data Source=127.0.0.1;Initial Catalog=RTPay;Persist Security Info=True;User ID=sa;Password=123456";
            _dal = new SqlServerDAL();
        }
        [TestMethod()]
        public void GetUserCreateTableInfoTest()
        {
            List<SqlServerTableModel> listM = _dal.GetUserCreateTableInfo();
            Assert.IsTrue(listM != null && listM.Count > 0);
        }
        [TestMethod()]
        public void GetTableColumnInfoByTableIDTest()
        {
            List<SqlServerColumnModel> listM = _dal.GetTableColumnInfoByTableID(1237579447);
            Assert.IsTrue(listM != null && listM.Count > 0);
        }
    }
}