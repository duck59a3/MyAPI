﻿namespace MyWebApi.Enums
{
    public enum PaymentStatus
    {
        Pending = 1, // Đang chờ thanh toán
        Paid = 2, // Đã thanh toán
        Failed = 3, // Thanh toán thất bại
        Refunded = 4 // Đã hoàn tiền
    }
}
