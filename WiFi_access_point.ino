/*
Create a WiFi access point and provide a web server on it. 
For tutorial video of this code, watch out this video
https://youtu.be/fcmb_3aBfH4
  visit 
  http://www.techiesms.com
  for IoT project tutorials.
  
        #techiesms
  explore | learn | share
*/

#include <ESP8266WiFi.h>
#include <WiFiClient.h> 
#include <ESP8266WebServer.h>

/* Set these to your desired credentials. */
const char *ssid = "Arduino Colombo"; // You can change it according to your ease
const char *password = ""; // You can change it according to your ease                                                                                                                  FORSE DOVRESTI SE NON ALTRO CHIUDERE IL COMPUTER, COLOMBO...

const int led = D0;
int buzzer = D1;

const int a=D3;  
const int b=D4;  
const int c=D5;  
const int d=D6;  
const int e=D7;  
const int f=D8;  
const int g=D2; 

ESP8266WebServer server(80); // establishing server at port 80 (HTTP protocol's default port)


// Writing a simple HTML page.
char HTML[] = "<html><body><h1>Accensione led</h1><a href=\"http://192.168.4.1/1\">Cambia pagina  </a> <div> <button><a href=\"toggle\">Accendi LED</a></button> <button><a href=\"spegni\">Spegni LED</a></button> <div> <button><a href=\"accendi_buzzer\">Accendi Buzzer</a></button> <button><a href=\"spegni_buzzer\">Spegni Buzzer</a></button> </body></html>"; // --> Simple HTML page


// This function will be called whenever anyone requests 192.168.4.1 within the local area connection of this ESP module.
void handleRoot() 
{
  server.send(200, "text/html",HTML);
}

// This function will be called whenever anyone requests 192.168.4.1/1 within the local area connection of this ESP module.
void Page1()
{
  server.send(200, "text/html", "<h1>Scegli il numero per il display</h1> <div> <button><a href=\"uno\">1</a></button> <button><a href=\"due\">2</a></button> <button><a href=\"tre\">3</a></button> <div> <button><a href=\"quattro\">4</a></button> <button><a href=\"cinque\">5</a></button> <button><a href=\"Sei\">6</a></button> <div> <button><a href=\"sette\">7</a></button> <button><a href=\"otto\">8</a></button> <button><a href=\"nove\">9</a></button> <div> <a href=\"http://192.168.4.1\">Cambia pagina  </a>  ");
}


// This function will be called whenever anyone requests 192.168.4.1/toggle within the local area connection of this ESP module.
void toggle()
{
  digitalWrite(LED_BUILTIN,!digitalRead(LED_BUILTIN));
  digitalWrite(led, HIGH);
  server.send(200, "text/html",HTML);
}
void spegni()
{
  digitalWrite(led, LOW);
  server.send(200, "text/html",HTML);
}
void accendi_buzzer()
{
  tone(buzzer,1000,2000);
  server.send(200, "text/html",HTML);
}
void spegni_buzzer()
{
  noTone(buzzer);
  server.send(200, "text/html",HTML);
}
void uno(){
      digitalWrite(a, LOW);  
    digitalWrite(b, HIGH);  
    digitalWrite(c, HIGH);   
    digitalWrite(d, LOW);   
    digitalWrite(e, LOW);  
    digitalWrite(f, LOW);  
    digitalWrite(g, LOW);
    server.send(200, "text/html", "<h1>Scegli il numero per il display</h1> <div> <button><a href=\"uno\">1</a></button> <button><a href=\"due\">2</a></button> <button><a href=\"tre\">3</a></button> <div> <button><a href=\"quattro\">4</a></button> <button><a href=\"cinque\">5</a></button> <button><a href=\"Sei\">6</a></button> <div> <button><a href=\"sette\">7</a></button> <button><a href=\"otto\">8</a></button> <button><a href=\"nove\">9</a></button>");
}
  
void due(){
      digitalWrite(a, HIGH);  
    digitalWrite(b, HIGH);  
    digitalWrite(c, LOW);   
    digitalWrite(d, LOW);   
    digitalWrite(e, HIGH);  
    digitalWrite(f, LOW);  
    digitalWrite(g, HIGH); 
    server.send(200, "text/html", "<h1>Scegli il numero per il display</h1> <div> <button><a href=\"uno\">1</a></button> <button><a href=\"due\">2</a></button> <button><a href=\"tre\">3</a></button> <div> <button><a href=\"quattro\">4</a></button> <button><a href=\"cinque\">5</a></button> <button><a href=\"Sei\">6</a></button> <div> <button><a href=\"sette\">7</a></button> <button><a href=\"otto\">8</a></button> <button><a href=\"nove\">9</a></button>");

  }
void tre(){
    digitalWrite(a, HIGH);  
    digitalWrite(b, HIGH);  
    digitalWrite(c, HIGH);   
    digitalWrite(d, HIGH);   
    digitalWrite(e, LOW);  
    digitalWrite(f, LOW);  
    digitalWrite(g, LOW);
    server.send(200, "text/html", "<h1>Scegli il numero per il display</h1> <div> <button><a href=\"uno\">1</a></button> <button><a href=\"due\">2</a></button> <button><a href=\"tre\">3</a></button> <div> <button><a href=\"quattro\">4</a></button> <button><a href=\"cinque\">5</a></button> <button><a href=\"Sei\">6</a></button> <div> <button><a href=\"sette\">7</a></button> <button><a href=\"otto\">8</a></button> <button><a href=\"nove\">9</a></button>");   
  }
  void quattro(){
    digitalWrite(a, LOW);  
    digitalWrite(b, HIGH);  
    digitalWrite(c, HIGH);                          
    digitalWrite(d, LOW);                                 
    digitalWrite(e, LOW);                                             
    digitalWrite(f, HIGH);                                          
    digitalWrite(g, HIGH);
    server.send(200, "text/html", "<h1>Scegli il numero per il display</h1> <div> <button><a href=\"uno\">1</a></button> <button><a href=\"due\">2</a></button> <button><a href=\"tre\">3</a></button> <div> <button><a href=\"quattro\">4</a></button> <button><a href=\"cinque\">5</a></button> <button><a href=\"Sei\">6</a></button> <div> <button><a href=\"sette\">7</a></button> <button><a href=\"otto\">8</a></button> <button><a href=\"nove\">9</a></button>");   
  }
  void cinque(){
    digitalWrite(a, HIGH);  
    digitalWrite(b, LOW);  
    digitalWrite(c, HIGH);   
    digitalWrite(d, HIGH);   
    digitalWrite(e, LOW);  
    digitalWrite(f, HIGH);  
    digitalWrite(g, HIGH);
    server.send(200, "text/html", "<h1>Scegli il numero per il display</h1> <div> <button><a href=\"uno\">1</a></button> <button><a href=\"due\">2</a></button> <button><a href=\"tre\">3</a></button> <div> <button><a href=\"quattro\">4</a></button> <button><a href=\"cinque\">5</a></button> <button><a href=\"Sei\">6</a></button> <div> <button><a href=\"sette\">7</a></button> <button><a href=\"otto\">8</a></button> <button><a href=\"nove\">9</a></button>");    
  }
  void Sei(){
     digitalWrite(a, HIGH);  
    digitalWrite(b, LOW);  
    digitalWrite(c, HIGH);   
    digitalWrite(d, HIGH);   
    digitalWrite(e, HIGH);  
    digitalWrite(f, HIGH);  
    digitalWrite(g, HIGH);
    server.send(200, "text/html", "<h1>Scegli il numero per il display</h1> <div> <button><a href=\"uno\">1</a></button> <button><a href=\"due\">2</a></button> <button><a href=\"tre\">3</a></button> <div> <button><a href=\"quattro\">4</a></button> <button><a href=\"cinque\">5</a></button> <button><a href=\"Sei\">6</a></button> <div> <button><a href=\"sette\">7</a></button> <button><a href=\"otto\">8</a></button> <button><a href=\"nove\">9</a></button>");  
  }
  void sette(){
     digitalWrite(a, HIGH);  
    digitalWrite(b, HIGH);  
    digitalWrite(c, HIGH);   
    digitalWrite(d, LOW);   
    digitalWrite(e, LOW);  
    digitalWrite(f, LOW);  
    digitalWrite(g, LOW);  
    server.send(200, "text/html", "<h1>Scegli il numero per il display</h1> <div> <button><a href=\"uno\">1</a></button> <button><a href=\"due\">2</a></button> <button><a href=\"tre\">3</a></button> <div> <button><a href=\"quattro\">4</a></button> <button><a href=\"cinque\">5</a></button> <button><a href=\"Sei\">6</a></button> <div> <button><a href=\"sette\">7</a></button> <button><a href=\"otto\">8</a></button> <button><a href=\"nove\">9</a></button>");
  }
  void otto(){
     digitalWrite(a, HIGH);  
    digitalWrite(b, HIGH);  
    digitalWrite(c, HIGH);   
    digitalWrite(d, HIGH);   
    digitalWrite(e, HIGH);  
    digitalWrite(f, HIGH);  
    digitalWrite(g, HIGH); 
    server.send(200, "text/html", "<h1>Scegli il numero per il display</h1> <div> <button><a href=\"uno\">1</a></button> <button><a href=\"due\">2</a></button> <button><a href=\"tre\">3</a></button> <div> <button><a href=\"quattro\">4</a></button> <button><a href=\"cinque\">5</a></button> <button><a href=\"Sei\">6</a></button> <div> <button><a href=\"sette\">7</a></button> <button><a href=\"otto\">8</a></button> <button><a href=\"nove\">9</a></button>");
  }
  void nove(){
     digitalWrite(a, HIGH);  
    digitalWrite(b, HIGH);  
    digitalWrite(c, HIGH);   
    digitalWrite(d, HIGH);   
    digitalWrite(e, LOW);  
    digitalWrite(f, HIGH);  
    digitalWrite(g, HIGH);   
    server.send(200, "text/html", "<h1>Scegli il numero per il display</h1> <div> <button><a href=\"uno\">1</a></button> <button><a href=\"due\">2</a></button> <button><a href=\"tre\">3</a></button> <div> <button><a href=\"quattro\">4</a></button> <button><a href=\"cinque\">5</a></button> <button><a href=\"Sei\">6</a></button> <div> <button><a href=\"sette\">7</a></button> <button><a href=\"otto\">8</a></button> <button><a href=\"nove\">9</a></button>");
  }  

void setup() {
  delay(1000);
  pinMode(LED_BUILTIN,OUTPUT);
  pinMode(led,OUTPUT);
  pinMode(buzzer,OUTPUT);
  digitalWrite(led,LOW);
  digitalWrite(a,LOW);
  digitalWrite(b,LOW);
  digitalWrite(c,LOW);
  digitalWrite(d,LOW);
  digitalWrite(e,LOW);
  digitalWrite(f,LOW);
  digitalWrite(g,LOW);
  Serial.begin(115200);
  Serial.println();

  Serial.print("Configuring access point...");
  /* You can remove the password parameter if you want the AP to be open. */
  WiFi.softAP(ssid, password); // --> This line will create a WiFi hotspot.

  IPAddress myIP = WiFi.softAPIP();
  Serial.print("AP IP address: ");
  Serial.println(myIP);
  server.on("/", handleRoot);
  server.on("/1",Page1);
  server.on("/toggle",toggle);
  server.on("/spegni",spegni);
  server.on("/accendi_buzzer",accendi_buzzer);
  server.on("/spegni_buzzer",spegni_buzzer);
  server.on("/uno",uno);
  server.on("/due",due);
  server.on("/tre",tre);
  server.on("/quattro",quattro);
  server.on("/cinque",cinque);
  server.on("/Sei",Sei);
  server.on("/sette",sette);
  server.on("/otto",otto);
  server.on("/nove",nove);
  server.begin();
  Serial.println("HTTP server started");
}

void loop() {
  server.handleClient();
}
