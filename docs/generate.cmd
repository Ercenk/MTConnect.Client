docker run --rm --name autorest -v "%cd%"\out:/out -v "%cd%"\:/input azuresdk/autorest autorest --input-file=/input/openAPI_1.3.1.yaml --csharp --output-folder=/out --namespace=MTConnect.Client
move .\out\*.* ..\src\MTConnect.Client\Client\Generated


