module github.com/pulumi/pulumi-akamai

go 1.13

replace (
	github.com/Azure/go-autorest => github.com/Azure/go-autorest v12.4.3+incompatible
	github.com/hashicorp/consul => github.com/hashicorp/consul/sdk v0.4.0
	github.com/hashicorp/vault => github.com/hashicorp/vault v1.2.0
)

require (
	cloud.google.com/go/logging v1.0.0 // indirect
	github.com/frankban/quicktest v1.4.1 // indirect
	github.com/hashicorp/golang-lru v0.5.3 // indirect
	github.com/hashicorp/terraform v0.12.9
	github.com/pierrec/lz4 v2.2.6+incompatible // indirect
	github.com/pulumi/pulumi v1.8.0
	github.com/pulumi/pulumi-terraform v0.18.4-0.20200206215737-990ad90a5d31
	github.com/stretchr/testify v1.4.1-0.20191106224347-f1bd0923b832
	github.com/terraform-providers/terraform-provider-akamai v0.5.0
)
