﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            PapaBobs.DTO.OrderDTO orderDTO = new DTO.OrderDTO();

            orderDTO.OrderId = Guid.NewGuid();
            orderDTO.Size = 1;
            orderDTO.Crust = 0;
            orderDTO.Pepperoni = true;
            orderDTO.Name = "Test";
            orderDTO.Address = "123 Elm";
            orderDTO.ZipCode = "12345";
            orderDTO.Phone = "555-5555";
            orderDTO.PaymentType = 0;
            orderDTO.TotalCost = 16.50M;

            Domain.OrderManager.CreateOrder(orderDTO);
        }
    }
}