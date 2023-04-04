# VTEX SDK

The [VTEX platform](https://www.nuget.org/packages/VTEX) SDK for .NET projects (both Core & Framework).

[![GitHub license](https://img.shields.io/github/license/guibranco/VTEX-SDK-dotnet)](https://github.com/guibranco/VTEX-SDK-dotnet)

![VTEX logo](https://raw.githubusercontent.com/guibranco/VTEX-SDK-dotnet/main/logo.png)

## CI/CD

| Build status | Last commit | Tests | Coverage | Code Smells | LoC | 
|--------------|-------------|-------|----------|-------------|-----|
| [![Build status](https://ci.appveyor.com/api/projects/status/kuso66xs0ljrcxfn/branch/main?svg=true)](https://ci.appveyor.com/project/guibranco/vtex-sdk-dotnet/branch/main) | [![GitHub last commit](https://img.shields.io/github/last-commit/guibranco/VTEX-SDK-dotnet/main)](https://github.com/guibranco/VTEX-SDK-dotnet) | ![AppVeyor tests (branch)](https://img.shields.io/appveyor/tests/guibranco/vtex-sdk-dotnet/main?compact_message) | [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=guibranco_VTEX-SDK-dotnet&metric=coverage)](https://sonarcloud.io/dashboard?id=guibranco_VTEX-SDK-dotnet) | [![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=guibranco_VTEX-SDK-dotnet&metric=code_smells)](https://sonarcloud.io/dashboard?id=guibranco_VTEX-SDK-dotnet) | [![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=guibranco_VTEX-SDK-dotnet&metric=ncloc)](https://sonarcloud.io/dashboard?id=guibranco_VTEX-SDK-dotnet)

## Code Quality

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/0db3e765696d4ce18f223aacc38aed47)](https://www.codacy.com/gh/guibranco/VTEX-SDK-dotnet/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=guibranco/VTEX-SDK-dotnet&amp;utm_campaign=Badge_Grade)
[![Codacy Badge](https://app.codacy.com/project/badge/Coverage/0db3e765696d4ce18f223aacc38aed47)](https://www.codacy.com/gh/guibranco/VTEX-SDK-dotnet/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=guibranco/VTEX-SDK-dotnet&amp;utm_campaign=Badge_Grade)

[![codecov](https://codecov.io/gh/guibranco/VTEX-SDK-dotnet/branch/main/graph/badge.svg)](https://codecov.io/gh/guibranco/VTEX-SDK-dotnet)
[![CodeFactor](https://www.codefactor.io/repository/github/guibranco/VTEX-SDK-dotnet/badge)](https://www.codefactor.io/repository/github/guibranco/VTEX-SDK-dotnet)

[![Maintainability](https://api.codeclimate.com/v1/badges/adc8920697c01bc3e108/maintainability)](https://codeclimate.com/github/guibranco/VTEX-SDK-dotnet/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/adc8920697c01bc3e108/test_coverage)](https://codeclimate.com/github/guibranco/VTEX-SDK-dotnet/test_coverage)

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=guibranco_VTEX-SDK-dotnet&metric=alert_status)](https://sonarcloud.io/dashboard?id=guibranco_VTEX-SDK-dotnet)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_VTEX-SDK-dotnet&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=guibranco_VTEX-SDK-dotnet)

[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=guibranco_VTEX-SDK-dotnet&metric=sqale_index)](https://sonarcloud.io/dashboard?id=guibranco_VTEX-SDK-dotnet)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=guibranco_VTEX-SDK-dotnet&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=guibranco_VTEX-SDK-dotnet)

[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_VTEX-SDK-dotnet&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=guibranco_VTEX-SDK-dotnet)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_VTEX-SDK-dotnet&metric=security_rating)](https://sonarcloud.io/dashboard?id=guibranco_VTEX-SDK-dotnet)

[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=guibranco_VTEX-SDK-dotnet&metric=bugs)](https://sonarcloud.io/dashboard?id=guibranco_VTEX-SDK-dotnet)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=guibranco_VTEX-SDK-dotnet&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=guibranco_VTEX-SDK-dotnet)

---

## Installation

### Github Releases

[![GitHub last release](https://img.shields.io/github/release-date/guibranco/VTEX-SDK-dotnet.svg?style=flat)](https://github.com/guibranco/VTEX-SDK-dotnet) [![Github All Releases](https://img.shields.io/github/downloads/guibranco/VTEX-SDK-dotnet/total.svg?style=flat)](https://github.com/guibranco/VTEX-SDK-dotnet)

Download the latest zip file from the [Release](https://github.com/GuiBranco/VTEX-SDK-dotnet/releases) page.

### Nuget package manager

| Package | Version | Downloads |
|------------------|:-------:|:-------:|
| **VTEX** | [![VTEX NuGet Version](https://img.shields.io/nuget/v/VTEX.svg?style=flat)](https://www.nuget.org/packages/VTEX/) | [![VTEX NuGet Downloads](https://img.shields.io/nuget/dt/VTEX.svg?style=flat)](https://www.nuget.org/packages/VTEX/) |
| **VTEX.Health** | [![VTEX Health NuGet Version](https://img.shields.io/nuget/v/VTEX.Health.svg?style=flat)](https://www.nuget.org/packages/VTEX.Health/) | [![VTEX Health NuGet Downloads](https://img.shields.io/nuget/dt/VTEX.Health.svg?style=flat)](https://www.nuget.org/packages/VTEX.Health/) |

---

## Features

Implements all features of VTEX API available at [VTEX Developer Docs](https://developers.vtex.com/)

---

## Usage

Use your VTEX platform API keys.
Follow this tutorial on how to: [Creating appKeys and appTokens to authenticate integrations](https://help.vtex.com/tutorial/creating-appkeys-and-apptokens-to-authenticate-integrations--43tQeyQJgAKGEuCqQKAOI2)

```cs
var vtex = new VTEXContext("store name", "app-key-xyz", "app-token-secret-hash");
var order = vtex.GetOrder("V-123456789-01");
Console.WriteLine("Sequence: {1} | Value: {0} | ", order.Value, order.Sequence);

```
