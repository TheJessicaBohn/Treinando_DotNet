# What´s your Kibbe?
- Em construção :construction:!
- Primeiro Comando: dotnet new mvc. Note que serão criadas essas pastinhas <br>
 ![image](https://user-images.githubusercontent.com/47541659/155630498-536f052d-db50-4d44-b564-7ecd271d0b32.png)
 - Agora execute seu programa com dotnet run, e cluque no link da imagem abaixo:
 ![image](https://user-images.githubusercontent.com/47541659/155630652-06434728-ca05-4346-95b6-29774f67988d.png)
- E no seu navegador irá aparecer esta página:
![image](https://user-images.githubusercontent.com/47541659/155630774-435a9f12-d6ef-4c9b-a743-5dc660c43cde.png)
- Execute o comando ```ctrl+C``` para parar de executar o projeto, e instale os pacotes:
- SQLite: ```dotnet add package Microsoft.EntityFrameworkCore.Sqlite```;
- Componentes de tempo de design compartilhados para ferramentas Entity Framework Core: ```dotnet add package Microsoft.EntityFrameworkCore.Design```;
- As ferramentas da CLI (interface de linha de comando):``` dotnet tool install --global dotnet-ef```;
## :game_die: DataBase:
- Para definir tabelas, e colunas utilizamos das migrations:
- E para isso temos o AppicationDBContext, que define quais tabelas serão criadas;
- Migration:```dotnet ef migrations add PrimeiraVersao```;
- Se caso der esse erro, execute:```dotnet tool update --global dotnet-ef```
![image](https://user-images.githubusercontent.com/47541659/155632975-b9145292-bfa4-4d8d-bdc0-ad2d7437b98d.png)



