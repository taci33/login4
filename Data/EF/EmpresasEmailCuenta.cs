using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class EmpresasEmailCuenta
{
    public int IdemailAccount { get; set; }

    public int EmpresaId { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public string EmailAddress { get; set; }

    public string DisplayName { get; set; }

    public string ReplyToAddress { get; set; }

    public string Organization { get; set; }

    /// <summary>
    /// (1 = SMTP)
    /// </summary>
    public int ServerTypeId { get; set; }

    public string Host { get; set; }

    public short Port { get; set; }

    public int Timeout { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public bool EnableSsl { get; set; }

    public bool UseDefaultCredentials { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }
}
