docker run --rm \
	-v $PWD:/local openapitools/openapi-generator-cli generate \
	-i /local/easee-openapi.json \
	-g csharp-netcore \
	--additional-properties=packageName=kern.services.EaseeClient,targetFramework=net7.0 \
	-o /local/kern.services.EaseeClient
