# azure_functions_timertrigger
azure functions timer triggered example which writes into a txt file every time it get triggered

## Azure function timer triggered  example 


### 1,  Create a new project from VisualStudio and select azure function template and select timer trigger option  

### 2, Clone this repo 

### Below Changes are  done to execute this locally

   #### i Update the AzureWebJobsStorage in  local.settings.json as below 
   
   ![image](https://user-images.githubusercontent.com/11384742/209768294-7170a5ac-a28d-4be0-8098-792216222f6a.png)
   
   #### ii update the Run method with RunOnStartup =true as below 
   
   ![image](https://user-images.githubusercontent.com/11384742/209768712-41f47d7f-4858-4f62-8c2d-d156538a3eaf.png)
   
   #### hit the start and this will trigger every minute based in the cron expression paramter value "0 * * * * *" in the TimerTrigger 
         will write into file named FunctionLog.txt in folder  azure_functions_timertrigger\bin\Debug\net6.0 
   
   ![image](https://user-images.githubusercontent.com/11384742/209768940-ba0ba389-93f9-4222-b4f6-38a109b17a18.png)
   
