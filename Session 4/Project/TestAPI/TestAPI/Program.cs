

HttpClient client = new HttpClient();
client.DefaultRequestHeaders.Add("ApiKey", "token");
int survey_id = 1;
var uri = $"https://survey.porsline.ir/api/v2/surveys/{survey_id}/";
var response=await client.GetAsync(uri);
var content=await response.Content.ReadAsStringAsync();

