using Microsoft.AspNetCore.Mvc;
//using System.Collection.Generics;

namespace HartIntercivicProject.Controllers
{

[ApiController]
[Route("api/[controller]")]
public class TimerListController : ControllerBase
{
    [HttpGet("get.{format}"), FormatFilter]
    public IEnumerable<myList> Get()
    {
    
        //pp Linq to sql can be useful here to get data from RDMS using Entity Framework
        List<myList> timerOrderList = new List<myList>{

            new myList{Description = "Table", Count = 2},
            new myList{Description = "Chair", Count = 18}
        };
        return timerOrderList;
    }
    
    ///pp Other methods can be implemeted below.
    //pp getbyId
    //pp post
    //pp Put
    //pp Delet

    /*[httpPost("post.{format}"), FormatFilter]
    public myList post([FromBody] myList mylist){
        if(ModelState.IsValid){
            return mylist;
        }
        else{
                return null;
        }
    }*/
}

}


