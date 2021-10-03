using SayisalLoto.API.DataLayer;
using SayisalLoto.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayisalLoto.API.BusinessLayer
{
    public class Business
    {
        public List<ReturnModel> GetData(InputModel inputModel)
        {
            var data = new Data();
            var jsonData = data.LoadAndGetJson();
            // filtreleme işlemi yapılacak
            var filtreDatas = new List<Ticket>();
            var returnModels = new List<ReturnModel>();
            filtreDatas = jsonData.DataList;
            if (inputModel.Month != null)
            {
                filtreDatas = filtreDatas.Where(x => x.Month == inputModel.Month.ToString()).ToList();
            }
            if (inputModel.Year != null)
            {
                filtreDatas = filtreDatas.Where(x => x.Year == inputModel.Year.ToString()).ToList();
            }
            if (inputModel.TicketNumber != null)
            {
                filtreDatas = filtreDatas.Where(x => x.TicketNumber == inputModel.TicketNumber.ToString()).ToList();
            }

            foreach (var item in filtreDatas)
            {
                var returnModel = new ReturnModel();
                returnModel.Month = item.Month;
                returnModel.Year = item.Year;
                returnModel.TicketNumber = item.TicketNumber;
                returnModel.LuckyNumbers = $"{item.LN1}-{item.LN2}-{item.LN3}-{item.LN4}-{item.LN5}-{item.LN6}+{item.Joker}";

                returnModels.Add(returnModel);
            }

            return returnModels;
        }
    }
}
