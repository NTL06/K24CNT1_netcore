using System;
using System.Collections.Generic;

namespace NTLLesson10EFDb.Models;

public partial class Ntlmember
{
    public long Id { get; set; }

    public string? NtluserName { get; set; }

    public string? Ntlpassword { get; set; }

    public string? NtlfullName { get; set; }

    public string? Ntlemail { get; set; }

    public string? Ntlphone { get; set; }

    public bool? Ntlstatus { get; set; }
}
