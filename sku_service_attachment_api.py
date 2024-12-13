from flask import Flask, request, jsonify

app = Flask(__name__)

# Endpoint to associate an attachment with a SKU Service
@app.route('/sku_service/attachment', methods=['POST'])
def associate_attachment():
    data = request.json
    # Logic to associate attachment
    return jsonify({"message": "Attachment associated successfully"}), 201

# Endpoint to disassociate an attachment from a SKU Service
@app.route('/sku_service/attachment', methods=['DELETE'])
def disassociate_attachment():
    data = request.json
    # Logic to disassociate attachment
    return jsonify({"message": "Attachment disassociated successfully"}), 200

if __name__ == '__main__':
    app.run(debug=True)
