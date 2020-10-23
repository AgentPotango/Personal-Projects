import unittest
from client3 import getDataPoint
from client3 import getRatio

class ClientTest(unittest.TestCase):
  def test_getDataPoint_calculatePrice(self):
    quotes = [
      {'top_ask': {'price': 121.2, 'size': 36}, 'timestamp': '2019-02-11 22:06:30.572453', 'top_bid': {'price': 120.48, 'size': 109}, 'id': '0.109974697771', 'stock': 'ABC'},
      {'top_ask': {'price': 121.68, 'size': 4}, 'timestamp': '2019-02-11 22:06:30.572453', 'top_bid': {'price': 117.87, 'size': 81}, 'id': '0.109974697771', 'stock': 'DEF'}
    ]
    """ ------------ Add the assertion below ------------ """
    #could create a trupleEqual but would have to create a new list with the same parameters as required by the getDataPoint function
    #As an example, you cannot do .assertTupleEquals(getDataPoint(quote), quote) due to the timestamp and id values as well as the lack of (top_bid+top_ask)/2
    for quote in quotes:
      self.assertEqual(getDataPoint(quote), (quote['stock'], quote['top_bid']['price'], quote['top_ask']['price'], (quote['top_bid']['price'] + quote['top_ask']['price'])/2))

  def test_getDataPoint_calculatePriceBidGreaterThanAsk(self):
    quotes = [
      {'top_ask': {'price': 119.2, 'size': 36}, 'timestamp': '2019-02-11 22:06:30.572453', 'top_bid': {'price': 120.48, 'size': 109}, 'id': '0.109974697771', 'stock': 'ABC'},
      {'top_ask': {'price': 121.68, 'size': 4}, 'timestamp': '2019-02-11 22:06:30.572453', 'top_bid': {'price': 127.87, 'size': 81}, 'id': '0.109974697771', 'stock': 'DEF'}
    ]
    """ ------------ Add the assertion below ------------ """
    for quote in quotes:
      self.assertEqual(getDataPoint(quote), (quote['stock'], quote['top_bid']['price'], quote['top_ask']['price'], (quote['top_bid']['price'] + quote['top_ask']['price'])/2))

    """ ------------ Add more unit tests ------------ """
  #Way more are possible. Just did some examples
  def test_getDataPoint_returnsZeroForAskPriceAndBidPriceAndPrice(self):
    stockValues = [
      {'stock': 'ABC', 'top_ask': {'price': 0, 'size': 36}, 'top_bid': {'price': 0, 'size': 36}}
    ]
    stockResults = ('ABC', 0.0, 0.0, 0.0)
    self.assertTupleEqual(getDataPoint(stockValues[0]), stockResults)

  def test_getDataPoint_returnsTypeErrorForNoInputValues(self):
    stockValues = []
    with self.assertRaises(TypeError): getDataPoint(stockValues)

  def test_getDataPoint_returnsTypeErrorForLessThanRequiredParameters(self):
    stockValues = [
      {'stock': 'ABC', 'top_ask': {'price': 0, 'size': 36}}
    ]
    with self.assertRaises(TypeError): getDataPoint(stockValues)

  #could inline these values, but chose to follow the style displayed previously.
  #Whilst some of these tests do not make sense within the context of stocks, I chose to do some anyway as I'm not sure what was expected of me.
  #Did not test for negative values when there could be some etc

  def test_getRatio_correctRatioReturned(self):
    priceValues = [200, 100]
    self.assertEqual(getRatio(priceValues[0], priceValues[1]), priceValues[0]/priceValues[1])

  def test_getRatio_calculatePriceAGreaterThanPriceB(self):
    priceValues = [200, 100]
    self.assertGreater(getRatio(priceValues[0], priceValues[1]), 1)

  def test_getRatio_calculatePriceALessThanPriceB(self):
    priceValues = [50, 100]
    self.assertLess(getRatio(priceValues[0], priceValues[1]), 1)

  def test_getRatio_calculatePriceAEqualToPriceB(self):
    priceValues = [100, 100]
    self.assertEqual(getRatio(priceValues[0], priceValues[1]), 1)

  def test_getRatio_calculatePriceAZeroAndPriceBGreaterThanZero(self):
    priceValues = [0, 100]
    self.assertEqual(getRatio(priceValues[0], priceValues[1]), 0)

  def test_getRatio_calculatePriceAGreaterThan0PriceBZero(self):
    priceValues = [100, 0]
    self.assertIsNone(getRatio(priceValues[0], priceValues[1]))

  def test_getRatio_throwsErrorWhenNonnumericInput(self):
    priceValues = ['apple', 100]
    with self.assertRaises(TypeError): getRatio(priceValues[0], priceValues[1])

  def test_getRatio_throwsErrorWhenNoParameters(self):
    with self.assertRaises(TypeError): getRatio()

  #Example using previous style.
  # def test_getRatio_calculatePriceAGreaterThanPriceB(self):
  #   quotes = [
  #     {'top_ask': {'price': 122.2, 'size': 36}, 'timestamp': '2019-02-11 22:06:30.572453',
  #      'top_bid': {'price': 120.48, 'size': 109}, 'id': '0.109974697771', 'stock': 'ABC'},
  #     {'top_ask': {'price': 120.68, 'size': 4}, 'timestamp': '2019-02-11 22:06:30.572453',
  #      'top_bid': {'price': 115.87, 'size': 81}, 'id': '0.109974697771', 'stock': 'DEF'}
  #   ]

  # prices = {}
  # for quote in quotes:
  #   stock, bid_price, ask_price, price = getDataPoint(quote)
  #   prices[stock] = price
  # self.assertEqual(getRatio(prices['ABC'], prices['DEF']), prices['ABC'] / prices['DEF'])

if __name__ == '__main__':
  unittest.main()
