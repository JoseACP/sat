private static X509Certificate2 ObtenerKey(string thumbprint)
{
    X509Store store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
    store.Open(OpenFlags.ReadOnly);
    var certificates = store.Certificates;
    var certificatesEnc = certificates.Find(X509FindType.FindByThumbprint, thumbprint, false);
    if (certificatesEnc.Count > 0)
    {
        X509Certificate2 certificate = certificatesEnc[0];
        return certificate;
    }
    
    return null;
}

autentification.ClientCredencials.ClientCertificate.Certificate = certi[0];
string token = autentification.Autentica();