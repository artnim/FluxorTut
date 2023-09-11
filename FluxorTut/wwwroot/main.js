window.Murkel = {
    callDotNet: function (dotNetHelper, name) {
        dotNetHelper.invokeMethodAsync('CallDotNet.SetResult', `Name: ${name}`);
    }
}
