# WebApiDataOrbis

# Titles and internal titles
 - Written by Sinikiwe Nangoku Jumba (2021), as DataOrbis Intermediate Software Developer Assessment.

# Introduction
 1.  Please find below the description of the assessment https://drive.google.com/drive/folders/13_SNIK5Cy1hYVFz7Xcm5RxsGF6K90N8Q
 2  I have used swaager instead of Postman postman library due to the pressure and other commitment I was getting from my other work size, I hope that will not bring disadvantages.
 3.  I have decided to use sql database to store data by creating a sql scripture to create a data with the same schema as provided in dataOrbis json data.
 4.  The script to create data schama and populate it is also provided here : https://docs.google.com/document/d/e/2PACX-1vTYXOHaCGKd9HilxGdFTUZnRVoLCneGurBrLM6ubiZgLW1fdmQxf6mLiJ8vryxZIt52NG-36Mh7ipCZ/pub 
 
 
 # Launch proccess.
 -  Run the above mentioned script on on the link in line 4.
 -  Get the connection string from data source and plave in in your appsettings json file that can be found at your root file.
   
 - How my conn string looked like : 
 
    "AllowedHosts": "*",
    "ConnectionStrings": {
    "WebApiDataOrbisContext": " ---"
  }
  
 -  should you connect them both and start running them on the same machine with your Angular app they start to interact. 
 -  NB : ensure the port number are on their default i.e 4200 for FE and  44385 BE
