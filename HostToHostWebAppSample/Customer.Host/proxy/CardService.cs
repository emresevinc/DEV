﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="CardServiceSoap", Namespace="http://tempuri.org/")]
public partial class CardService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback GetCardListByCustomerNumberOperationCompleted;
    
    private System.Threading.SendOrPostCallback GetCardByCardRefNumberOperationCompleted;
    
    /// <remarks/>
    public CardService() {
        this.Url = "http://localhost/Card.Host/WebServices/CardService.asmx";
    }
    
    /// <remarks/>
    public event GetCardListByCustomerNumberCompletedEventHandler GetCardListByCustomerNumberCompleted;
    
    /// <remarks/>
    public event GetCardByCardRefNumberCompletedEventHandler GetCardByCardRefNumberCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCardListByCustomerNumber", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public Card[] GetCardListByCustomerNumber(long customerNumber) {
        object[] results = this.Invoke("GetCardListByCustomerNumber", new object[] {
                    customerNumber});
        return ((Card[])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginGetCardListByCustomerNumber(long customerNumber, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetCardListByCustomerNumber", new object[] {
                    customerNumber}, callback, asyncState);
    }
    
    /// <remarks/>
    public Card[] EndGetCardListByCustomerNumber(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Card[])(results[0]));
    }
    
    /// <remarks/>
    public void GetCardListByCustomerNumberAsync(long customerNumber) {
        this.GetCardListByCustomerNumberAsync(customerNumber, null);
    }
    
    /// <remarks/>
    public void GetCardListByCustomerNumberAsync(long customerNumber, object userState) {
        if ((this.GetCardListByCustomerNumberOperationCompleted == null)) {
            this.GetCardListByCustomerNumberOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCardListByCustomerNumberOperationCompleted);
        }
        this.InvokeAsync("GetCardListByCustomerNumber", new object[] {
                    customerNumber}, this.GetCardListByCustomerNumberOperationCompleted, userState);
    }
    
    private void OnGetCardListByCustomerNumberOperationCompleted(object arg) {
        if ((this.GetCardListByCustomerNumberCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetCardListByCustomerNumberCompleted(this, new GetCardListByCustomerNumberCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCardByCardRefNumber", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public Card[] GetCardByCardRefNumber(string cardRefNumber) {
        object[] results = this.Invoke("GetCardByCardRefNumber", new object[] {
                    cardRefNumber});
        return ((Card[])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginGetCardByCardRefNumber(string cardRefNumber, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetCardByCardRefNumber", new object[] {
                    cardRefNumber}, callback, asyncState);
    }
    
    /// <remarks/>
    public Card[] EndGetCardByCardRefNumber(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Card[])(results[0]));
    }
    
    /// <remarks/>
    public void GetCardByCardRefNumberAsync(string cardRefNumber) {
        this.GetCardByCardRefNumberAsync(cardRefNumber, null);
    }
    
    /// <remarks/>
    public void GetCardByCardRefNumberAsync(string cardRefNumber, object userState) {
        if ((this.GetCardByCardRefNumberOperationCompleted == null)) {
            this.GetCardByCardRefNumberOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCardByCardRefNumberOperationCompleted);
        }
        this.InvokeAsync("GetCardByCardRefNumber", new object[] {
                    cardRefNumber}, this.GetCardByCardRefNumberOperationCompleted, userState);
    }
    
    private void OnGetCardByCardRefNumberOperationCompleted(object arg) {
        if ((this.GetCardByCardRefNumberCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetCardByCardRefNumberCompleted(this, new GetCardByCardRefNumberCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
public partial class Card {
    
    private string cardNumberField;
    
    private long customerNumberField;
    
    private string cardRefNumberField;
    
    /// <remarks/>
    public string CardNumber {
        get {
            return this.cardNumberField;
        }
        set {
            this.cardNumberField = value;
        }
    }
    
    /// <remarks/>
    public long CustomerNumber {
        get {
            return this.customerNumberField;
        }
        set {
            this.customerNumberField = value;
        }
    }
    
    /// <remarks/>
    public string CardRefNumber {
        get {
            return this.cardRefNumberField;
        }
        set {
            this.cardRefNumberField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void GetCardListByCustomerNumberCompletedEventHandler(object sender, GetCardListByCustomerNumberCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetCardListByCustomerNumberCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetCardListByCustomerNumberCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public Card[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Card[])(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void GetCardByCardRefNumberCompletedEventHandler(object sender, GetCardByCardRefNumberCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetCardByCardRefNumberCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetCardByCardRefNumberCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public Card[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Card[])(this.results[0]));
        }
    }
}
