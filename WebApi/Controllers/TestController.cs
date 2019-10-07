using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.DataModel;

namespace WebApi.Controllers
{
    public class TestController : ApiController
    {
        /// <summary>
        /// 條件查詢
        /// </summary>
        /// <param name="stockId">查詢參數</param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult Get([FromUri(Name = "stockId")] string stockId)
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

        /// <summary>
        /// 無條件查詢
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult CommonSearch()
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

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Post([FromBody]StockData data)
        {
            try
            {
                //implement insert into database atcion
                return Request.CreateResponse(HttpStatusCode.OK, "Successful message");
            }
            catch (Exception ie)
            {
                StockData result = new StockData();
                return Request.CreateResponse(HttpStatusCode.OK, "Error Message");
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// 
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPut]
        public HttpResponseMessage Put([FromBody]StockData data)
        {
            try
            {
                //implement update database atcion
                string result = string.Format("Successful, update StockID {0} close prcie to {1}", data.StockID, data.ClosePrice);
                return Request.CreateResponse(HttpStatusCode.OK, "Successful message");
            }
            catch (Exception ie)
            {
                StockData result = new StockData();
                return Request.CreateResponse(HttpStatusCode.OK, "Error Message");
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// 
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpDelete]
        public HttpResponseMessage Delete([FromBody]StockData data)
        {
            try
            {
                //implement update database atcion
                string result = string.Format("Successful, Delete Data StockID =  {0}", data.StockID);
                return Request.CreateResponse(HttpStatusCode.OK, "Successful message");
            }
            catch (Exception ie)
            {
                StockData result = new StockData();
                return Request.CreateResponse(HttpStatusCode.OK, "Error Message");
            }
        }
    }
}
