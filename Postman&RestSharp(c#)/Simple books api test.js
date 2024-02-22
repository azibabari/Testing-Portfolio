pm.test("Status code is 200", function () {
  pm.response.to.have.status(200);
});
pm.test("Response body contains id,name,availability and type of books", function () {
  const responseData = pm.response.json();
  pm.expect(responseData).to.be.an('array').that.is.not.empty;
  responseData.forEach(function(item) {
    pm.expect(item).to.have.property('id');
    pm.expect(item).to.have.property('name');
    pm.expect(item).to.have.property('available');
    pm.expect(item).to.have.property('type');
    pm.expect(item.id).to.be.a('number'); 
    pm.expect(item.name).to.be.a('string');
    pm.expect(item.available).to.be.a('boolean');
    pm.expect(item.type).to.be.a('string');
  });
});
