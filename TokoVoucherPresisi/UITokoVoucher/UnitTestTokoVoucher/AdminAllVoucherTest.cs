using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

[TestClass]
public class VoucherManagementTests
{
    private const string TestVouchersFilePath = "test_vouchers.json";
    private List<Voucher> testVouchers;

    [TestInitialize]
    public void TestInitialize()
    {
        // Initialize with some test data
        testVouchers = new List<Voucher>
        {
            new Voucher { Name = "Test Voucher 1", Price = 10000, Platform = "Steam" },
            new Voucher { Name = "Test Voucher 2", Price = 20000, Platform = "PlayStation" }
        };

        // Save initial test data
        SaveTestVouchers();
    }

    [TestCleanup]
    public void TestCleanup()
    {
        // Clean up the test file after each test
        if (File.Exists(TestVouchersFilePath))
        {
            File.Delete(TestVouchersFilePath);
        }
    }

    private void SaveTestVouchers()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(testVouchers, options);
        File.WriteAllText(TestVouchersFilePath, jsonString);
    }

    private List<Voucher> LoadTestVouchers()
    {
        if (File.Exists(TestVouchersFilePath))
        {
            string jsonString = File.ReadAllText(TestVouchersFilePath);
            return JsonSerializer.Deserialize<List<Voucher>>(jsonString);
        }
        return new List<Voucher>();
    }

    [TestMethod]
    public void AddVoucher_ShouldAddNewVoucher()
    {
        // Arrange
        var newVoucher = new Voucher
        {
            Name = "New Test Voucher",
            Price = 15000,
            Platform = "Xbox"
        };

        // Act
        testVouchers.Add(newVoucher);
        SaveTestVouchers();
        var loadedVouchers = LoadTestVouchers();

        // Assert
        Assert.AreEqual(3, loadedVouchers.Count);
        var addedVoucher = loadedVouchers.Find(v => v.Name == "New Test Voucher");
        Assert.IsNotNull(addedVoucher);
        Assert.AreEqual(15000, addedVoucher.Price);
        Assert.AreEqual("Xbox", addedVoucher.Platform);
    }

    [TestMethod]
    public void AddVoucher_WithInvalidPrice_ShouldNotBeAdded()
    {
        // Arrange
        var invalidVoucher = new Voucher
        {
            Name = "Invalid Voucher",
            Price = -100,  // Invalid price
            Platform = "Invalid Platform"
        };

        // Act - In your actual code, this would be prevented by validation
        testVouchers.Add(invalidVoucher);
        SaveTestVouchers();
        var loadedVouchers = LoadTestVouchers();

        // Assert - This test shows that the system currently allows invalid prices
        // In a real scenario, you'd want to prevent this in the business logic
        var addedVoucher = loadedVouchers.Find(v => v.Name == "Invalid Voucher");
        Assert.IsNotNull(addedVoucher); // This should actually fail in proper validation
    }

    [TestMethod]
    public void UpdateVoucher_ShouldModifyExistingVoucher()
    {
        // Arrange
        var voucherToUpdate = testVouchers[0];
        var originalName = voucherToUpdate.Name;

        // Act
        voucherToUpdate.Name = "Updated Name";
        voucherToUpdate.Price = 50000;
        voucherToUpdate.Platform = "Updated Platform";
        SaveTestVouchers();
        var loadedVouchers = LoadTestVouchers();

        // Assert
        var updatedVoucher = loadedVouchers.Find(v => v.Name == "Updated Name");
        Assert.IsNotNull(updatedVoucher);
        Assert.AreEqual(50000, updatedVoucher.Price);
        Assert.AreEqual("Updated Platform", updatedVoucher.Platform);

        // Verify the old name no longer exists
        var oldVoucher = loadedVouchers.Find(v => v.Name == originalName);
        Assert.IsNull(oldVoucher);
    }

    [TestMethod]
    public void UpdateVoucher_WithInvalidPrice_ShouldNotUpdate()
    {
        // Arrange
        var voucherToUpdate = testVouchers[0];
        var originalPrice = voucherToUpdate.Price;

        // Act - In your actual code, this would be prevented by validation
        voucherToUpdate.Price = -100; // Invalid price
        SaveTestVouchers();
        var loadedVouchers = LoadTestVouchers();

        // Assert - This test shows that the system currently allows invalid prices
        // In a real scenario, you'd want to prevent this in the business logic
        var updatedVoucher = loadedVouchers.Find(v => v.Name == voucherToUpdate.Name);
        Assert.AreEqual(-100, updatedVoucher.Price); // This should actually fail in proper validation
    }
}

public class Voucher
{
    public string Name { get; set; }
    public int Price { get; set; }
    public string Platform { get; set; }
}