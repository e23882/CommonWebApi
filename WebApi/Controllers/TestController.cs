using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new
            {
                status = "1",
                message = "access ok",
                page = 1,
                pagesize = 1,
                totalpage = 1,
                datanum = 10000
              ,
                data = new[] {
               new{stockId="1101",stockName="台泥",exchange="TSE",issued="54656192",currency="台幣",stockTypeCode="EB011000",stockTypeName="上市水泥"},
               new{stockId="6666",stockName="測試股1",exchange="TSE",issued="54656666",currency="台幣",stockTypeCode="EB011000",stockTypeName="上市水泥"}
                }
            });
        }
    }
}
