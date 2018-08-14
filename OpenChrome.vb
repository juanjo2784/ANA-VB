Imports System.Text
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Firefox
Imports OpenQA.Selenium.IE
Imports OpenQA.Selenium.Support.Events
Imports OpenQA.Selenium.Support.UI
Module OpenChrome
    Dim service As ChromeDriverService = ChromeDriverService.CreateDefaultService
    Dim driver1 As ChromeDriver = Nothing
    Dim driver As EventFiringWebDriver
    Public Sub OpenPage(ByVal url As String, usr As String, pwd As String, key As String, btn As String)
        Dim chromeOptions As New OpenQA.Selenium.Chrome.ChromeOptions()
        chromeOptions.AddExcludedArgument("ignore-certificate-errors")
        chromeOptions.AddArgument("test-type")
        service.HideCommandPromptWindow = True
        driver1 = New ChromeDriver(service, chromeOptions)
        driver = New EventFiringWebDriver(driver1)
        driver.Navigate().GoToUrl(url)
        Try
            System.Threading.Thread.Sleep(2000)
            Dim Usuario As IWebElement = driver.FindElement(By.Name(usr))
            Usuario.SendKeys(Environment.UserName)
            Dim Password As IWebElement = driver.FindElement(By.Name(pwd))
            Password.SendKeys(key)
            Try
                Dim acceder As IWebElement = driver.FindElement(By.Id(btn))
                acceder.Click()
            Catch ex As Exception
                MsgBox("Error al logearse")
            End Try
            Console.Read()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub OpenPage2(ByVal url As String, usr As String, pwd As String, key As String)
        Dim chromeOptions As New OpenQA.Selenium.Chrome.ChromeOptions()
        chromeOptions.AddExcludedArgument("ignore-certificate-errors")
        chromeOptions.AddArgument("test-type")
        service.HideCommandPromptWindow = True
        driver1 = New ChromeDriver(service, chromeOptions)
        driver = New EventFiringWebDriver(driver1)
        driver.Navigate().GoToUrl(url)
        Try
            System.Threading.Thread.Sleep(2000)
            Dim Usuario As IWebElement = driver.FindElement(By.Name(usr))
            Usuario.SendKeys(Environment.UserName)
            Dim Password As IWebElement = driver.FindElement(By.Name(pwd))
            Password.SendKeys(key)
            Console.Read()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub OpenIE(ByVal url As String, usr As String, pwd As String, key As String, btn As String)
        Dim IEOptions As New OpenQA.Selenium.IE.InternetExplorerOptions()
        Dim driverIE As IWebDriver
        driverIE = New InternetExplorerDriver
        service.HideCommandPromptWindow = True
        driverIE.Navigate().GoToUrl(url)
        Try
            Dim Usuario As IWebElement = driverIE.FindElement(By.Name(usr))
            Usuario.SendKeys(Environment.UserName)
            Dim Password As IWebElement = driverIE.FindElement(By.Name(pwd))
            Password.SendKeys(key)
            Try
                System.Threading.Thread.Sleep(2000)
                Dim acceder As IWebElement = driverIE.FindElement(By.Id(btn))
                acceder.Click()
            Catch ex As Exception

            End Try
            Console.Read()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Prueba()
        Dim fdriver As IWebDriver = New FirefoxDriver
        fdriver.Navigate().GoToUrl("https://www.google.com")
        Console.Read()
    End Sub

End Module
