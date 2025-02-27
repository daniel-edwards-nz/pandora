package testing

import "fmt"

func (tb TestBuilder) generateProviderBlock(_ *testDependencies) (*string, error) {
	out := fmt.Sprintf(`
provider "%s" {
  features {}
}
`, tb.providerPrefix)
	return &out, nil
}
