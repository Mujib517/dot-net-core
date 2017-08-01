<h1>.Net Core Application with docker deployment</h1>

To run:

1. dotnet restore
2. dotnet build
3. dotnet run
4. dotnet publish -o dist
5. docker build -t webapi .


To deploy:

1. docker run -d -p:80:8080 webapi