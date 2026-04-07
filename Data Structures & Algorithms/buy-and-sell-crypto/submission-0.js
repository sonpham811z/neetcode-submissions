class Solution {
    /**
     * @param {number[]} prices
     * @return {number}
     */
    maxProfit(prices) {
        // Khởi tạo giá thấp nhất là vô cực để đảm bảo giá đầu tiên luôn được chọn làm minPrice
        let minPrice = Infinity;
        // Khởi tạo lợi nhuận tối đa là 0
        let maxProfit = 0;

        // Duyệt qua từng ngày
        for (let i = 0; i < prices.length; i++) {
            const currentPrice = prices[i];

            // Nếu giá hôm nay thấp hơn giá thấp nhất đã từng thấy
            if (currentPrice < minPrice) {
                // Cập nhật giá thấp nhất mới
                minPrice = currentPrice;
            }
            // Nếu bán hôm nay có lời nhiều hơn mức lợi nhuận kỷ lục hiện tại
            // (Lưu ý: Chúng ta chỉ so sánh khi không cập nhật minPrice)
            else if (currentPrice - minPrice > maxProfit) {
                // Cập nhật lợi nhuận tối đa
                maxProfit = currentPrice - minPrice;
            }
        }

        return maxProfit;
    }
}