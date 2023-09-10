# Configure the Azure provider
terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~> 3.71.0"
    }
  }

  required_version = ">= 1.1.0"
}

provider "azurerm" {
  features {}
}

resource "azurerm_resource_group" "vgt2_rg" {
  name     = "vgt2"
  location = "West Europe"

  lifecycle {
    prevent_destroy = true
  }
}

# Create the Linux App Service Plan
resource "azurerm_service_plan" "vgt2_appserviceplan" {
  name                = "webapp-service-plan-vgt2"
  location            = azurerm_resource_group.vgt2_rg.location
  resource_group_name = azurerm_resource_group.vgt2_rg.name
  os_type             = "Windows"
  sku_name            = "F1"

  lifecycle {
    prevent_destroy = true
  }
}

# Create the web app, pass in the App Service Plan IDaz
resource "azurerm_windows_web_app" "vgt2_api" {
  name                  = "webapp-vgt2"
  location              = azurerm_resource_group.vgt2_rg.location
  resource_group_name   = azurerm_resource_group.vgt2_rg.name
  service_plan_id       = azurerm_service_plan.vgt2_appserviceplan.id
  https_only            = true
  site_config { 
    local_mysql_enabled   = true
    minimum_tls_version = "1.2"
    always_on = false

    application_stack {
      current_stack = "dotnet"
      dotnet_version = "v7.0"
    }
  }

  lifecycle {
    prevent_destroy = true
  }
}