docker run --rm --name autorest -v "`pwd`"/out:/out -v "`pwd`"/:/input azuresdk/autorest autorest --input-file=/input/openAPI_1.3.1.yaml --csharp --output-folder=/out --namespace=MTConnect.Client
mv out/*.* ../src/MTConnect.Client/Client/
    