using Microsoft.AnalysisServices.Tabular;

Server server=new Server();
server.Connect(@".");

server.Databases["Contoso"].Refresh();
//foreach (Database database in server.Databases)
//{
//    Console.WriteLine(database.Name);
//}

//var model=server.Databases["Contoso"].Model;

////foreach (var table in model.Tables)
////{
////    Console.WriteLine(table.Name);
////}

//var salesTable = model.Tables["Sales"];

//foreach (var measure in salesTable.Measures)
//{
//    Console.WriteLine(measure.Name+":"+measure.Expression);
//}





//server.Databases.Add(database);
//database.Update(Microsoft.AnalysisServices.UpdateOptions.ExpandFull,
//    Microsoft.AnalysisServices.UpdateMode.Create);







