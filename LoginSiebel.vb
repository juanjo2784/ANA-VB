Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Module LoginSiebel

    Sub main()
        Dim driver As IWebDriver
        driver = New ChromeDriver
        driver.Navigate().GoToUrl("www.google.com")
    End Sub

End Module
