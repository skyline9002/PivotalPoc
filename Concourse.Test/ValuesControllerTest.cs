using Concourse.Api.Controllers;
using System;
using Xunit;

namespace Concourse.Test
{
   public class ValuesControllerTest
   {
      private ValuesController _Controller;

      public ValuesControllerTest() {
         this._Controller = new ValuesController();
      }

      [Fact]
      public void Test1() {
         Assert.True(true);
      }

   }
}
