using Microsoft.AspNetCore.Mvc;
using System.Collection.Generics;
using System.Xml;


namespace HartIntercivicProject.Controllers
{
    
[ApiController]
[Route("[controller]")]
public class TimerListController : ControllerBase
{

    private IWebHostEnvironment Environment;
    public TimerListController(IWebHostEnvironment environment){
        Environment = environment;
    }

    [HttpGet("get.{format}"), FormatFilter]
    public IEnumerable<myList> Get()
    {
        List<myList> timerOrderList = new List<myList>();
        XmlDocument doc = new XmlDocument();
        doc.Load(string.Concat(this.Environment.WebRootPath, "/Data.xml"));


        foreach(XmlNode node in doc.SelectNodes("/ArrayOfMyList/myList"))
        {
            timerOrderList.Add(new myList{
                Description = node["Description"].InnerText,
                Count = int.Parse(node["Count"].InnerText)
            });
        }
        
        /*List<myList> timerOrderList = new List<myList>{

            new myList{Description = "Table", Count = 2},
            new myList{Description = "Chair", Count = 18}
        };*/
        //return timerOrderList;
    //}

    /*[httpPost("post.{format}"), FormatFilter]
    public myList post([FromBody] myList mylist){
        if(ModelState.IsValid){
            return mylist;
        }
        else{
                return null;
        }
    }*/
//}

//}*/











using Microsoft.AspNetCore.Mvc;
using System.Collection.Generics;

namespace HartIntercivicProject.Controllers
{

[ApiController]
[Route("api/[controller]")]
public class TimerListController : ControllerBase
{
    [HttpGet("get.{format}"), FormatFilter]
    public IEnumerable<myList> Get()
    {

        // use can LINQ to sql to get all list
        List<myList> timerOrderList = new List<myList>{

            new myList{Description = "Table", Count = 2},
            new myList{Description = "Chair", Count = 18},
            new myList{Description = "Bed", Count = 9},
            new myList{Description = "Dining", Count = 1},
            new myList{Description = "Sofa", Count = 4},
            new myList{Description = "T.V.", Count = 3},
            new myList{Description = "Dressing", Count = 4},
            new myList{Description = "Rug", Count = 14}
        
        };
        return timerOrderList;
    }
    //getbyId 
    //post
}

}


