using Dapper;
using System;
using System.Data;

namespace Models.Domain.Enums;

public class EStatusTypeHandler : SqlMapper.TypeHandler<EStatus>
{
    public override void SetValue(IDbDataParameter parameter, EStatus value)
    {
        parameter.Value = value == EStatus.Normal ? "N" : "B";
    }

    public override EStatus Parse(object value)
    {
        return value.ToString() == "N" ? EStatus.Normal : EStatus.Bloqueado;
    }
}