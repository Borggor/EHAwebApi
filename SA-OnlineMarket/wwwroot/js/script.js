function openStore()
{
    console.log("Open store");
    window.open("SA-OnlineMarket\Views\Product\Index.cshtml", "_blank");
}

function openLogin()
{
    console.log("Open login");
    window.open("SA-OnlineMarket\Views\Login\Index.cshtml", "_blank");
}

function confirmLogin(string)
{
    console.log("Confirming login");
    pass = string;
    realPass;
    if (pass == realPass)
    {
        console.log("Login Succesfull");
    }
}