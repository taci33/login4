using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DmnDataSetParameter
{
    public int Idparameter { get; set; }

    public int DataSetId { get; set; }

    public int UsrTypeId { get; set; }

    public int OperatorId { get; set; }

    public string Name { get; set; }

    public string Caption { get; set; }

    public virtual DmnDataSet DataSet { get; set; }

    public virtual GsUsrOperator Operator { get; set; }

    public virtual GsUsrType UsrType { get; set; }
}
