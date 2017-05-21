
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class MutationTestingSession
{

    private MutationTestingSessionMutants mutantsField;

    private MutationTestingSessionMutantCodeListing[] codeDifferenceListingsField;

    private MutationTestingSessionTestedMutant[] detailedTestingResultsField;

    private System.DateTime sessionCreationWindowShowTimeField;

    private System.DateTime sessionStartTimeField;

    private System.DateTime sessionEndTimeField;

    private decimal sessionRunTimeSecondsField;

    private byte mutationScoreField;

    /// <remarks/>
    public MutationTestingSessionMutants Mutants
    {
        get
        {
            return this.mutantsField;
        }
        set
        {
            this.mutantsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("MutantCodeListing", IsNullable = false)]
    public MutationTestingSessionMutantCodeListing[] CodeDifferenceListings
    {
        get
        {
            return this.codeDifferenceListingsField;
        }
        set
        {
            this.codeDifferenceListingsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("TestedMutant", IsNullable = false)]
    public MutationTestingSessionTestedMutant[] DetailedTestingResults
    {
        get
        {
            return this.detailedTestingResultsField;
        }
        set
        {
            this.detailedTestingResultsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime SessionCreationWindowShowTime
    {
        get
        {
            return this.sessionCreationWindowShowTimeField;
        }
        set
        {
            this.sessionCreationWindowShowTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime SessionStartTime
    {
        get
        {
            return this.sessionStartTimeField;
        }
        set
        {
            this.sessionStartTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime SessionEndTime
    {
        get
        {
            return this.sessionEndTimeField;
        }
        set
        {
            this.sessionEndTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal SessionRunTimeSeconds
    {
        get
        {
            return this.sessionRunTimeSecondsField;
        }
        set
        {
            this.sessionRunTimeSecondsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte MutationScore
    {
        get
        {
            return this.mutationScoreField;
        }
        set
        {
            this.mutationScoreField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class MutationTestingSessionMutants
{

    private MutationTestingSessionMutantsAssembly[] assemblyField;

    private ushort totalField;

    private byte liveField;

    private byte markedAsEquivalentAmongLiveField;

    private byte unpairedFirstOrderMutantsField;

    private ushort killedField;

    private byte untestedField;

    private byte withErrorField;

    private decimal averageCreationTimeMilisecondsField;

    private decimal averageTestingTimeMilisecondsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Assembly")]
    public MutationTestingSessionMutantsAssembly[] Assembly
    {
        get
        {
            return this.assemblyField;
        }
        set
        {
            this.assemblyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort Total
    {
        get
        {
            return this.totalField;
        }
        set
        {
            this.totalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Live
    {
        get
        {
            return this.liveField;
        }
        set
        {
            this.liveField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte MarkedAsEquivalentAmongLive
    {
        get
        {
            return this.markedAsEquivalentAmongLiveField;
        }
        set
        {
            this.markedAsEquivalentAmongLiveField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UnpairedFirstOrderMutants
    {
        get
        {
            return this.unpairedFirstOrderMutantsField;
        }
        set
        {
            this.unpairedFirstOrderMutantsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort Killed
    {
        get
        {
            return this.killedField;
        }
        set
        {
            this.killedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Untested
    {
        get
        {
            return this.untestedField;
        }
        set
        {
            this.untestedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte WithError
    {
        get
        {
            return this.withErrorField;
        }
        set
        {
            this.withErrorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal AverageCreationTimeMiliseconds
    {
        get
        {
            return this.averageCreationTimeMilisecondsField;
        }
        set
        {
            this.averageCreationTimeMilisecondsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal AverageTestingTimeMiliseconds
    {
        get
        {
            return this.averageTestingTimeMilisecondsField;
        }
        set
        {
            this.averageTestingTimeMilisecondsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class MutationTestingSessionMutantsAssembly
{

    private MutationTestingSessionMutantsAssemblyType[] typeField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Type")]
    public MutationTestingSessionMutantsAssemblyType[] Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class MutationTestingSessionMutantsAssemblyType
{

    private MutationTestingSessionMutantsAssemblyTypeMethod[] methodField;

    private string nameField;

    private string namespaceField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Method")]
    public MutationTestingSessionMutantsAssemblyTypeMethod[] Method
    {
        get
        {
            return this.methodField;
        }
        set
        {
            this.methodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Namespace
    {
        get
        {
            return this.namespaceField;
        }
        set
        {
            this.namespaceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class MutationTestingSessionMutantsAssemblyTypeMethod
{

    private MutationTestingSessionMutantsAssemblyTypeMethodMutant[] mutantField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Mutant")]
    public MutationTestingSessionMutantsAssemblyTypeMethodMutant[] Mutant
    {
        get
        {
            return this.mutantField;
        }
        set
        {
            this.mutantField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class MutationTestingSessionMutantsAssemblyTypeMethodMutant
{

    private MutationTestingSessionMutantsAssemblyTypeMethodMutantErrorInfo errorInfoField;

    private string idField;

    private string descriptionField;

    private string stateField;

    private bool isEquivalentField;

    private ushort creationTimeMilisecondsField;

    private ushort testingTimeMilisecondsField;

    private decimal testingEndRelativeSecondsField;

    /// <remarks/>
    public MutationTestingSessionMutantsAssemblyTypeMethodMutantErrorInfo ErrorInfo
    {
        get
        {
            return this.errorInfoField;
        }
        set
        {
            this.errorInfoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string State
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool IsEquivalent
    {
        get
        {
            return this.isEquivalentField;
        }
        set
        {
            this.isEquivalentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort CreationTimeMiliseconds
    {
        get
        {
            return this.creationTimeMilisecondsField;
        }
        set
        {
            this.creationTimeMilisecondsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort TestingTimeMiliseconds
    {
        get
        {
            return this.testingTimeMilisecondsField;
        }
        set
        {
            this.testingTimeMilisecondsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TestingEndRelativeSeconds
    {
        get
        {
            return this.testingEndRelativeSecondsField;
        }
        set
        {
            this.testingEndRelativeSecondsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class MutationTestingSessionMutantsAssemblyTypeMethodMutantErrorInfo
{

    private string descriptionField;

    private string exceptionMessageField;

    /// <remarks/>
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    public string ExceptionMessage
    {
        get
        {
            return this.exceptionMessageField;
        }
        set
        {
            this.exceptionMessageField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class MutationTestingSessionMutantCodeListing
{

    private string codeField;

    private string mutantIdField;

    /// <remarks/>
    public string Code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MutantId
    {
        get
        {
            return this.mutantIdField;
        }
        set
        {
            this.mutantIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class MutationTestingSessionTestedMutant
{

    private MutationTestingSessionTestedMutantTests testsField;

    private string mutantIdField;

    private ushort testingTimeMilisecondsField;

    /// <remarks/>
    public MutationTestingSessionTestedMutantTests Tests
    {
        get
        {
            return this.testsField;
        }
        set
        {
            this.testsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MutantId
    {
        get
        {
            return this.mutantIdField;
        }
        set
        {
            this.mutantIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort TestingTimeMiliseconds
    {
        get
        {
            return this.testingTimeMilisecondsField;
        }
        set
        {
            this.testingTimeMilisecondsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class MutationTestingSessionTestedMutantTests
{

    private MutationTestingSessionTestedMutantTestsTestClass[] testClassField;

    private byte numberOfFailedTestsField;

    private byte numberOfPassedTestsField;

    private byte numberOfInconlusiveTestsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TestClass")]
    public MutationTestingSessionTestedMutantTestsTestClass[] TestClass
    {
        get
        {
            return this.testClassField;
        }
        set
        {
            this.testClassField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte NumberOfFailedTests
    {
        get
        {
            return this.numberOfFailedTestsField;
        }
        set
        {
            this.numberOfFailedTestsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte NumberOfPassedTests
    {
        get
        {
            return this.numberOfPassedTestsField;
        }
        set
        {
            this.numberOfPassedTestsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte NumberOfInconlusiveTests
    {
        get
        {
            return this.numberOfInconlusiveTestsField;
        }
        set
        {
            this.numberOfInconlusiveTestsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class MutationTestingSessionTestedMutantTestsTestClass
{

    private MutationTestingSessionTestedMutantTestsTestClassTestMethod[] testMethodField;

    private string nameField;

    private string fullNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TestMethod")]
    public MutationTestingSessionTestedMutantTestsTestClassTestMethod[] TestMethod
    {
        get
        {
            return this.testMethodField;
        }
        set
        {
            this.testMethodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FullName
    {
        get
        {
            return this.fullNameField;
        }
        set
        {
            this.fullNameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class MutationTestingSessionTestedMutantTestsTestClassTestMethod
{

    private string messageField;

    private string nameField;

    private string outcomeField;

    /// <remarks/>
    public string Message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Outcome
    {
        get
        {
            return this.outcomeField;
        }
        set
        {
            this.outcomeField = value;
        }
    }
}

